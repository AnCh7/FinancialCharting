Ext.define('HighCharts.view.SideMenu', {
	extend: 'Ext.tab.Panel',
	alias: 'widget.sideMenu',
	requires: [
		'HighCharts.view.DataSourceAccordion',
		'HighCharts.view.SearchGrid'
	],
	activeTab: 0,
	plain: true,
	items: [
		{
			title: 'Quandl DataSources',
			xtype: 'dataSourceAccordion',
		},
		{
			title: 'Live Search',
			xtype: 'searchGrid'
		}
	]
});