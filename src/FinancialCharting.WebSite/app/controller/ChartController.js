function initMarketDataStore(arg) {
	var store = arg.getMarketDataStoreStore();
	store.on('load', arg.onLoad, arg, {
	});

	store.getProxy().extraParams = {
		DataSource: arg.sourceCode,
		Ticker: arg.code,
		Timeframe: arg.timeFrame,
		Transformation: arg.transformation,
		From: arg.from,
		To: arg.to
	};
	return store;
}

function reCreateChart(me, store) {
	var sb = Ext.getCmp('bottom');
	sb.setStatus({
		text: 'Ready',
		iconCls: 'x-status-valid'
	});

	if (HighCharts.updateTask) {
		HighCharts.updateTask.cancel();
	}

	var mainChart = Ext.getCmp('mainChart');
	if (mainChart) {
		Ext.getCmp('centerPane').remove(mainChart);
		mainChart.destroy();
	}

	var config;
	switch (me.sourceCode) {
		case 'BCHAIN':
		case 'EUREKA':
		case 'ML':
		case 'RENCAP':
		case 'WFE':
		case 'WGC':
		case 'WREN':
		case 'THAISE':
		case 'WSJ':
		case 'DMDRN':
		case 'SEC':
			config = adapter.HighStockConfig.getConfig('DataOneField');
			break;
		case 'QUANDL':
		case 'PSYCH':
			if (me.columns.length == 3) {
				config = adapter.HighStockConfig.getConfig('DataTwoFields');
			}
			if (me.columns.length == 4) {
				config = adapter.HighStockConfig.getConfig('DataThreeFields');
			}
			break;
		case 'FINRA':
			if (me.columns.length == 4) {
				config = adapter.HighStockConfig.getConfig('DataThreeFields');
			}
			break;
		case 'PHILSE':
			config = adapter.HighStockConfig.getConfig('OhlcData');
			break;
		case 'GOOG':
			config = adapter.HighStockConfig.getConfig('OhlcvData');
			break;
		case 'ASX':
			if (me.columns.length == 2) {
				config = adapter.HighStockConfig.getConfig('DataOneField');
			}
			else {
				config = adapter.HighStockConfig.getConfig('OhlcvOpenInterestData');
			}
			break;
		case 'EUREX':
		case 'LIFFE':
		case 'MGEX':
		case 'PXDATA':
			config = adapter.HighStockConfig.getConfig('OhlcvOpenInterestData');
			break;
		case 'BUDAPESTSE':
			if (me.columns.length == 2) {
				config = adapter.HighStockConfig.getConfig('DataOneField');
			}
			else {
				config = adapter.HighStockConfig.getConfig('OhlcData');
			}
			break;
		case 'SGX':
			config = adapter.HighStockConfig.getConfig('SGXData');
			break;
		case 'YAHOO':
			if (me.columns.length == 6) {
				config = adapter.HighStockConfig.getConfig('OhlcvData');
			}
			else {
				config = adapter.HighStockConfig.getConfig('YAHOOData');
			}
			break;
		default:
			if (me.columns.length == 2) {
				config = adapter.HighStockConfig.getConfig('DataOneField');
				break;
			}
			if (me.columns.length == 3) {
				config = adapter.HighStockConfig.getConfig('DataTwoFields');
				break;
			}
			if (me.columns.length == 4) {
				config = adapter.HighStockConfig.getConfig('DataThreeFields');
				break;
			}
			if (me.columns.length == 5) {
				config = adapter.HighStockConfig.getConfig('DataFourFields');
				break;
			}
			if (me.columns.length == 6) {
				config = adapter.HighStockConfig.getConfig('DataFiveFields');
				break;
			}
	}
	if (!config) {
		sb.setStatus({
			text: "Not supported datasource",
			iconCls: 'x-status-error',
			clear: {
				wait: 5000,
				anim: false,
				useDefaults: false
			}
		});
		return null;
	}
	else {
		config.store = store;
		config.id = 'mainChart';

		mainChart = Ext.widget('highstock', config);
		mainChart.setTitle(me.name);

		for (var i = 0; i < mainChart.series.length; i++) {
			if (mainChart.series.hasOwnProperty(i)) {
				var attr = mainChart.series[i];
				if (attr.plot == 'spline') {
					attr.name = me.columns[i + 1];
				}
			}
		}

		Ext.getCmp('centerPane').add(mainChart);
		Ext.get('centerPane').mask("Please wait...");

		return mainChart;
	}
}

Ext.define('HighCharts.controller.ChartController', {
	extend: 'Ext.app.Controller',
	views: ['TickersGrid', 'SearchGrid'],
	models: ['Ticker', 'MarketData'],
	stores: ['TickerStore', 'MarketDataStore', 'SearchTickersStore'],
	init: function() {
		this.control({
			'tickersGrid': {
				selectionchange: this.tickersGridISelectionChange
			},
			'searchGrid': {
				selectionchange: this.searchGridSelectionChange
			}
		});
	},
	onLoad: function() {
		Ext.get('centerPane').unmask();
	},
	changeTimeframe: function(timeFrame) {
		var me = this;
		me.timeFrame = timeFrame;

		var store = initMarketDataStore(this);
		var mainChart = reCreateChart(me, store);
		if (mainChart) {
			mainChart.loadStores();
		}
	},
	changeTransformation: function(transformation) {
		var me = this;
		me.transformation = transformation;

		var store = initMarketDataStore(this);
		var mainChart = reCreateChart(me, store);
		if (mainChart) {
			mainChart.loadStores();
		}
	},
	changeDatePeriod: function(from, to) {
		var me = this;
		me.from = from;
		me.to = to;

		var store = initMarketDataStore(this);
		var mainChart = reCreateChart(me, store);
		if (mainChart) {
			mainChart.loadStores();
		}
	},
	tickersGridISelectionChange: function(arg, records) {
		if (records.length > 0) {
			var me = this;
			var record = records[0];
			me.sourceCode = record.data.source_code;
			me.code = record.data.code;
			me.name = record.data.name;
			me.columns = record.data.columns;

			var from = Ext.ComponentQuery.query('chartOptionsPanel #datefieldFrom')[0].rawValue;
			var to = Ext.ComponentQuery.query('chartOptionsPanel #datefieldTo')[0].rawValue;

			if (from && to) {
				me.from = from;
				me.to = to;
			}

			var store = initMarketDataStore(this);
			var mainChart = reCreateChart(me, store);
			if (mainChart) {
				mainChart.loadStores();
			}
		}
	},
	searchGridSelectionChange: function(arg, records) {
		if (records.length > 0) {
			var me = this;
			var record = records[0];
			me.sourceCode = record.data.source_code;
			me.code = record.data.code;
			me.name = record.data.name;
			me.columns = record.data.columns;

			var from = Ext.ComponentQuery.query('chartOptionsPanel #datefieldFrom')[0].rawValue;
			var to = Ext.ComponentQuery.query('chartOptionsPanel #datefieldTo')[0].rawValue;

			if (from && to) {
				me.from = from;
				me.to = to;
			}

			var store = initMarketDataStore(this);
			var mainChart = reCreateChart(me, store);
			if (mainChart) {
				mainChart.loadStores();
			}
		}
	}
});