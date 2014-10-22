Ext.define('HighCharts.model.Indicator', {
	extend: 'Ext.data.Model',
	fields: [
		'source_code',
		'code',
		'name',
		'description',
		'updated_at',
		'frequency',
		'from_date',
		'to_date'
	]
});