Ext.define('HighCharts.view.DataSourceAccordion', {
	extend: 'Ext.Container',
	alias: 'widget.dataSourceAccordion',
	requires: [
		'Ext.layout.container.Accordion',
		'HighCharts.store.DataSourceStore',
		'HighCharts.store.TickerStore',
		'HighCharts.view.TickersGrid'
	],
	xtype: 'layout-accordion',
	items: [],
	autoScroll: true,
	layout: {
		type: 'accordion',
		animate: false,
		multi: false,
		activeOnTop: false
	},
	initComponent: function() {
		var results = this.results = Ext.create('HighCharts.store.DataSourceStore');
		results.on('load', this.onLoad, this, {
			single: true
		});
		results.load();
		this.callParent(arguments);
	},
	onLoad: function() {
		var me = this;
		this.results.each(function(msg) {
			me.add(
			{
				xtype: "tickersGrid",
				title: msg.get("name"),
				msg: msg
			});
		});
	}
});