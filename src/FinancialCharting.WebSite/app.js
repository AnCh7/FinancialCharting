Ext.Loader.setConfig({
	enabled: true,
	paths: {
		'HighCharts': 'app',
		'Ext.ux.statusbar': 'libs/extjs/ux/statusbar/'
	}
});

Ext.override(Ext.data.proxy.JsonP, {
	constructor: function(config) {
		this.callOverridden([config]);
		this.addListener("exception", function(proxy, response, operation) {
			var sb = Ext.getCmp('bottom');
			sb.setStatus({
				text: response.responseStatus.Message,
				iconCls: 'x-status-error',
				clear: {
					wait: 5000,
					anim: false,
					useDefaults: false
				}
			});
			var mainChart = Ext.getCmp('mainChart');
			if (mainChart) {
				Ext.getCmp('centerPane').remove(mainChart);
				mainChart.destroy();
			}
		});
	}
});

Ext.override(Ext.data.reader.Reader, {
	constructor: function (config) {
		this.callOverridden([config]);
		this.addListener("exception", function (proxy, response, operation) {
			var sb = Ext.getCmp('bottom');
			sb.setStatus({
				text: response.responseStatus.Message,
				iconCls: 'x-status-error',
				clear: {
					wait: 5000,
					anim: false,
					useDefaults: false
				}
			});

			var mainChart = Ext.getCmp('mainChart');
			if (mainChart) {
				Ext.getCmp('centerPane').remove(mainChart);
				mainChart.destroy();
			}
		});
	}
});

Ext.define('Ext.data.Connection', { override: 'Ext.data.Connection', disableCaching: false });
Ext.define('Ext.data.proxy.Server', { override: 'Ext.data.proxy.Server', noCache: false });
Ext.define('Ext.data.JsonP', { override: 'Ext.data.JsonP', disableCaching: false });

Ext.require('adapter.HighStock');
Ext.require('adapter.HighStockConfig');
Ext.require('adapter.HighStockSerie');
Ext.require('Ext.ux.statusbar.StatusBar');

Ext.application({
	name: 'HighCharts',
	appFolder: 'app',
	stores: ['DataSourceStore', 'TickerStore', 'MarketDataStore', 'TimeFrameStore', 'TransformationStore', 'SearchTickersStore'],
	controllers: ['ChartController', 'ChartOptionsController'],
	autoCreateViewport: true
});