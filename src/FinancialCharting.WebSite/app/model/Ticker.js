Ext.define('HighCharts.model.Ticker', {
	extend: 'Ext.data.Model',
	fields: [
		'source_code',
		'code',
		'name',
		'description',
		'updated_at',
		'timeframe',
		'from_date',
		'to_date',
		'columns'
	]
});