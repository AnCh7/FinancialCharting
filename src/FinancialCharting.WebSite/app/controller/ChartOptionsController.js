Ext.define('HighCharts.controller.ChartOptionsController', {
	extend: 'Ext.app.Controller',
	controllers: ['ChartController'],
	views: ['ChartOptionsPanel'],
	models: ['TimeFrame', 'Transformation'],
	stores: ['TimeFrameStore', 'TransformationStore'],
	init: function() {
		this.control({
			'chartOptionsPanel #timeFrameCombobox': {
				select: this.timeFrameComboboxSelect
			},
			'chartOptionsPanel #transformationCombobox': {
				select: this.transformationComboboxSelect
			},
			'chartOptionsPanel #buttonLoad': {
				click: this.buttonLoadClick
			}
		});
	},
	timeFrameComboboxSelect: function(combo, records) {
		try {
			this.getController('ChartController').changeTimeframe(records[0].data.code);
		}
		catch (ex) {
			Ext.Error.raise('Application error: Controller [ChartController] is unavailable');
		}
	},
	transformationComboboxSelect: function(combo, records) {
		try {
			this.getController('ChartController').changeTransformation(records[0].data.code);
		}
		catch (ex) {
			Ext.Error.raise('Application error: Controller [ChartController] is unavailable');
		}
	},
	buttonLoadClick: function(e, eOpts) {
		var datefieldFrom = Ext.ComponentQuery.query('chartOptionsPanel #datefieldFrom')[0].rawValue;
		var datefieldTo = Ext.ComponentQuery.query('chartOptionsPanel #datefieldTo')[0].rawValue;
		try {
			if (datefieldFrom && datefieldTo) {
				this.getController('ChartController').changeDatePeriod(datefieldFrom, datefieldTo);
			}
		}
		catch (ex) {
			Ext.Error.raise('Application error: Controller [ChartController] is unavailable');
		}
	}
});