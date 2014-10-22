Ext.define('HighCharts.store.DataSourceStore', {
	extend: 'Ext.data.Store',
	requires: ['HighCharts.model.DataSource'],
	model: 'HighCharts.model.DataSource',
	alias: 'widget.dataSourceStore',
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