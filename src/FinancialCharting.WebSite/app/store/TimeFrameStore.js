Ext.define('HighCharts.store.TimeFrameStore', {
	extend: 'Ext.data.Store',
	model: 'HighCharts.model.TimeFrame',
	data: [
		{ "code": "none", "name": "None" },
		{ "code": "daily", "name": "Daily" },
		{ "code": "weekly", "name": "Weekly" },
		{ "code": "monthly", "name": "Monthly" },
		{ "code": "quarterly", "name": "Quarterly" },
		{ "code": "annual", "name": "Annual" }
	]
});