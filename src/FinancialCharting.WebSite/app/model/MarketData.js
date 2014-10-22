Ext.define('HighCharts.model.MarketData', {
	extend: 'Ext.data.Model',
	fields: [
		'date',
		'date_unix',
		'value',
		'value2',
		'value3',
		'value4',
		'value5',
		'rate',
		'high',
		'low',
		'open',
		'close',
		'volume',
		'openInterest',
		'settle',
		'adjustedClose'
	]
});