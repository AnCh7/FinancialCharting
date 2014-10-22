Ext.define('HighCharts.store.TransformationStore', {
	extend: 'Ext.data.Store',
	model: 'HighCharts.model.Transformation',
	data: [
		{ "code": "none", "name": "None" },
		{ "code": "diff", "name": "Diff" },
		{ "code": "rdiff", "name": "Rdiff" },
		{ "code": "cumul", "name": "Cumul" },
		{ "code": "normalize", "name": "Normalize" }
	]
});