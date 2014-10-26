Ext.Loader.setConfig({
	enabled: true,
	paths: {
		'HighCharts': 'app',
		'Ext.ux.statusbar': 'libs/extjs/ux/statusbar/'
	}
});

Ext.require('common.ErrorHandlingJsonP');
Ext.require('common.ErrorHandlingReader');

Ext.require('override.Connection');
Ext.require('override.JsonP');
Ext.require('override.Server');

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