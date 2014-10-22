Ext.define('HighCharts.store.IndicatorStore', {
	extend: 'Ext.data.Store',
	model: 'HighCharts.model.Indicator',
	alias: 'widget.indicatorStore',
	proxy: {
		type: 'jsonp',
		url: 'http://localhost:1476/financialDataSources',
		pageParam: undefined,
		startParam: undefined,
		limitParam: undefined,
		reader: {
			type: 'json',
			root: 'data',
			successProperty: 'success'
		}
	}
});