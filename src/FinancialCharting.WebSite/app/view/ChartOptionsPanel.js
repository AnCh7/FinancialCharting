Ext.define('HighCharts.view.ChartOptionsPanel', {
	extend: 'Ext.Container',
	alias: 'widget.chartOptionsPanel',
	requires: [
		'HighCharts.store.TimeFrameStore',
		'HighCharts.store.TransformationStore'
	],
	layout: {
		type: 'hbox',
		align: 'middle'
	},
	items: [
		{
			width: 70,
			xtype: 'label',
			text: 'Timeframe:',
			margin: '0 0 0 10'
		},
		{
			width: 90,
			id: 'timeFrameCombobox',
			xtype: 'combobox',
			queryMode: 'local',
			store: 'TimeFrameStore',
			displayField: 'name',
			valueField: 'code',
			margin: '0 10 0 0'
		},
		{
			width: 70,
			xtype: 'label',
			text: 'Transformation:',
			margin: '0 10 0 0'
		},
		{
			width: 90,
			id: 'transformationCombobox',
			xtype: 'combobox',
			queryMode: 'local',
			store: 'TransformationStore',
			displayField: 'name',
			valueField: 'code',
			margin: '0 50 0 0'
		},
		{
			width: 30,
			xtype: 'label',
			text: 'From:',
			margin: '0 10 0 0'
		},
		{
			width: 100,
			id: 'datefieldFrom',
			xtype: 'datefield',
			name: 'from_date',
			value: (function() {
				var date = new Date();
				date.setDate(date.getDate() - 365);
				return date;
			})(),
			margin: '0 10 0 0'
		},
		{
			width: 20,
			xtype: 'label',
			text: 'To:',
			margin: '0 10 0 0'
		},
		{
			width: 100,
			id: 'datefieldTo',
			xtype: 'datefield',
			name: 'to_date',
			value: new Date(),
			margin: '0 10 0 0'
		},
		{
			width: 70,
			id: 'buttonLoad',
			xtype: 'button',
			text: 'Load',
			margin: '0 10 0 0'
		}
	]
});