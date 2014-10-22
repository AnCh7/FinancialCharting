Ext.define('HighCharts.view.SearchGrid', {
	extend: 'Ext.grid.Panel',
	requires: [
		'Ext.toolbar.TextItem',
		'Ext.form.field.Text'
	],
	alias: 'widget.searchGrid',
	minHeight: 500,
	columnLines: true,
	searchValue: null,
	defaultStatusText: 'Nothing found',
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
			flex: 40 / 100,
			type: 'string'
		},
		{
			text: 'SourceCode',
			sortable: false,
			hideable: false,
			dataIndex: 'source_code',
			menuDisabled: 'true',
			flex: 30 / 100,
			type: 'string'
		}
	],
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
		var me = this;
		me.store = Ext.create('HighCharts.store.SearchTickersStore');
		this.on('render', this.onrender, this, {
			single: true
		});
		me.callParent(arguments);
	},
	onrender: function() {
		this.addDocked({
			xtype: 'toolbar',
			dock: 'top',
			items: [
				{
					xtype: 'label',
					text: 'Search:',
					width: 50
				},
				{
					xtype: 'textfield',
					name: 'searchField',
					hideLabel: true,
					width: 240
				},
				{
					xtype: 'button',
					text: 'Find',
					handler: this.onClick,
					scope: this,
					width: 50
				}
			]
		});
		this.addDocked({
			xtype: 'pagingtoolbar',
			store: this.store,
			dock: 'bottom',
			displayInfo: true,
			displayMsg: '{0}-{1} of {2}'
		});
	},
	afterRender: function() {
		var me = this;
		me.callParent(arguments);
		me.textField = me.down('textfield[name=searchField]');
		me.statusBar = me.down('statusbar[name=searchStatusBar]');
	},
	getSearchValue: function() {
		var me = this;
		var value = me.textField.getValue();
		if (value === '') {
			return null;
		}
		else {
			return value;
		}
	},
	onClick: function() {
		var me = this;
		me.view.refresh();
		me.searchValue = me.getSearchValue();

		if (me.searchValue !== null) {
			this.store.getProxy().extraParams = {
				Query: me.searchValue
			};
			me.store.load();
		}
	}
});