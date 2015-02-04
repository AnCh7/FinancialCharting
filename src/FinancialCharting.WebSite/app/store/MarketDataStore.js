Ext.define('HighCharts.store.MarketDataStore', {
	extend: 'Ext.data.Store',
	model: 'HighCharts.model.MarketData',
	alias: 'widget.marketDataStore',
	autoLoad: false,
	proxy: {
		type: "jsonp",
		pageParam: undefined,
		limitParam: undefined,
		startParam: undefined,
		url: 'http://localhost:1476/marketdata',
		//url: 'http://quandlcharting.azurewebsites.net/marketdata',
		extraParams:
		{
			DataSource: '',
			Ticker: '',
			Timeframe: '',
			Transformation: '',
			From: '',
			To: ''
		},
		reader: {
			type: 'json',
			root: 'data',
			successProperty: 'success'
		}
	}
});