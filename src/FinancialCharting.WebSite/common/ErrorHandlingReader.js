Ext.define('common.ErrorHandlingReader', {
	override: 'Ext.data.reader.Reader',
	constructor: function(config) {
		this.callOverridden([config]);
		this.addListener("exception", function(proxy, response, operation) {
			var sb = Ext.getCmp('bottom');
			sb.setStatus({
				text: (function() {
					if (response != null &&
						response.responseStatus != null &&
						response.responseStatus.Message != null) {
						return response.responseStatus.Message;
					}
					else {
						return "Error";
					}
				})(),
				iconCls: 'x-status-error',
				clear: {
					wait: 5000,
					anim: false,
					useDefaults: false
				}
			});

			var mainChart = Ext.getCmp('mainChart');
			if (mainChart) {
				Ext.getCmp('centerPane').remove(mainChart);
				mainChart.destroy();
			}
		});
	}
});