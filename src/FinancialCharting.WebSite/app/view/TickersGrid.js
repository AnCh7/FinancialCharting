Ext.define('HighCharts.view.TickersGrid', {
	extend: 'Ext.grid.Panel',
	alias: 'widget.tickersGrid',
	minHeight: 610,
	scroll: 'vertical',
	columnLines: true,
	columns: [
		{
			text: 'Code',
			sortable: false,
			hideable: false,
			dataIndex: 'code',
			menuDisabled: 'true',
			flex: 30 / 100,
			type: 'string'
		},
		{
			text: 'Name',
			sortable: false,
			hideable: false,
			dataIndex: 'name',
			menuDisabled: 'true',
			flex: 35 / 100,
			type: 'string'
		},
		{
			text: 'LastUpdated',
			sortable: false,
			hideable: false,
			dataIndex: 'updated_at',
			menuDisabled: 'true',
			renderer: Ext.util.Format.dateRenderer("Y-m-d H:i:s"),
			flex: 35 / 100,
			type: 'date'
		}
	],
	dockedItems: [],
	listeners: {
		'itemmouseenter': function(view) {
			Ext.create('Ext.tip.ToolTip', {
				target: view.el,
				delegate: view.itemSelector,
				trackMouse: true,
				renderTo: Ext.getBody(),
				listeners: {
					beforeshow: function updateTipBody(tip) {
						tip.update(tip.triggerElement.innerHTML);
					}
				}
			});
		}
	},
	initComponent: function() {

		this.store = Ext.create('HighCharts.store.TickerStore');

		this.store.getProxy().extraParams = {
			DataSource: this.msg.get('code')
		};

		this.on('render', this.onrender, this, {
			single: true
		});

		this.store.on('load', this.onload, this, {

		});

		this.callParent(arguments);
	},
	onload: function() {
		var model = this.getSelectionModel();
		model.select(0);
	},
	onrender: function() {
		this.addDocked({
			xtype: 'pagingtoolbar',
			store: this.store,
			dock: 'bottom',
			displayInfo: true,
			displayMsg: '{0}-{1} of {2}'
		});
		if (!this.collapsed) {
			this.store.load();
		}
		this.on('expand', this.onExpand, this, {
		
		});
	},
	onExpand: function() {
		this.store.load();
	}
});