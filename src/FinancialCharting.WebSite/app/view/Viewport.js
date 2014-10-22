Ext.define('HighCharts.view.Viewport', {
	extend: 'Ext.container.Viewport',
	id: 'viewport',
	requires: [
		'HighCharts.view.SideMenu',
		'HighCharts.view.ChartOptionsPanel'
	],
	layout: 'border',
	listeners: {
		render: {
			fn: function() {
				Ext.fly(Ext.getCmp('clock').getEl().parent()).addCls('x-status-text-panel').createChild({ cls: 'spacer' });
				Ext.TaskManager.start({
					run: function() {
						Ext.fly(Ext.getCmp('clock').getEl()).update(Ext.Date.format(new Date(), 'g:i:s A'));
					},
					interval: 1000
				});
			},
			delay: 100
		}
	},
	items: [
		{
			xtype: 'sideMenu',
			id: 'left',
			region: 'west',
			margins: '3 0 3 3',
			split: true,
			width: 350
		},
		{
			xtype: 'panel',
			region: 'center',
			margins: '3 3 3 0',
			id: 'centerPane',
			layout: 'fit',
			tbar: [
				{
					xtype: 'chartOptionsPanel',
					margin: '0 0 5 0'
				}
			]
		},
		{
			region: 'south',
			margins: '3 3 0 3',
			id: 'bottom',
			xtype: 'statusbar',
			defaultText: 'Ready',
			text: 'Ready',
			defaultIconCls: 'default-icon',
			iconCls: 'x-status-valid',
			autoHeight: true,
			border: false,
			items: [
				{
					xtype: 'tbtext',
					id: 'clock',
					text: Ext.Date.format(new Date(), 'g:i:s A')
				}
			]
		}
	]
});