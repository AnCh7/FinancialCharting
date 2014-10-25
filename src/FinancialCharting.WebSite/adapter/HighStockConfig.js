Ext.define("adapter.HighStockConfig", {
	statics: {
		getConfig: function(name) {
			if (adapter.HighStockConfig[name]) {
				return Ext.clone(adapter.HighStockConfig[name]);
			}
		},
		DataOneField: {
			series: [
				{
					plot: 'spline',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (record.data.value == null || record.data.value == 0) {
							result.push(null);
						}
						else {
							result.push(record.data.value);
						}
						return result;
					}
				}
			],
			chartConfig: {
				chart: {
					marginLeft: 10,
					marginRight: 10,
					alignTicks: false
				},
				rangeSelector: {
					selected: 5
				},
				title: { text: '' },
				yAxis: [
					{
						title: { text: '' },
						height: '100%',
						lineWidth: 2
					}
				],
			}
		},
		DataTwoFields: {
			series: [
				{
					plot: 'spline',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (record.data.value == null || record.data.value == 0) {
							result.push(0);
						}
						else {
							result.push(record.data.value);
						}
						return result;
					}
				},
				{
					plot: 'spline',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (record.data.value2 == null || record.data.value2 == 0) {
							result.push(0);
						}
						else {
							result.push(record.data.value2);
						}
						return result;
					},
					yAxis: 1
				}
			],
			chartConfig: {
				chart: {
					marginLeft: 10,
					marginRight: 10,
					alignTicks: false
				},
				rangeSelector: {
					selected: 5
				},
				title: { text: '' },
				yAxis: [
					{
						title: { text: '' },
						height: '50%',
						lineWidth: 2
					},
					{
						title: { text: '' },
						top: '50%',
						height: '50%',
						lineWidth: 1
					}
				]
			}
		},
		DataThreeFields: {
			series: [
				{
					plot: 'spline',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (record.data.value == null || record.data.value == 0) {
							result.push(0);
						}
						else {
							result.push(record.data.value);
						}
						return result;
					}
				},
				{
					plot: 'spline',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (record.data.value2 == null || record.data.value2 == 0) {
							result.push(0);
						}
						else {
							result.push(record.data.value2);
						}
						return result;
					},
					yAxis: 1
				},
				{
					plot: 'spline',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (record.data.value3 == null || record.data.value3 == 0) {
							result.push(0);
						}
						else {
							result.push(record.data.value3);
						}
						return result;
					},
					yAxis: 2
				}
			],
			chartConfig: {
				chart: {
					marginLeft: 10,
					marginRight: 10,
					alignTicks: false
				},
				rangeSelector: {
					selected: 5
				},
				title: { text: '' },
				yAxis: [
					{
						title: { text: '' },
						height: '50%',
						lineWidth: 2
					},
					{
						title: { text: '' },
						top: '50%',
						height: '25%',
						lineWidth: 1
					},
					{
						title: { text: '' },
						top: '75%',
						height: '25%',
						lineWidth: 1
					}
				]
			}
		},
		DataFourFields: {
			series: [
				{
					plot: 'spline',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (record.data.value == null || record.data.value == 0) {
							result.push(0);
						}
						else {
							result.push(record.data.value);
						}
						return result;
					}
				},
				{
					plot: 'spline',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (record.data.value2 == null || record.data.value2 == 0) {
							result.push(0);
						}
						else {
							result.push(record.data.value2);
						}
						return result;
					},
					yAxis: 1
				},
				{
					plot: 'spline',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (record.data.value3 == null || record.data.value3 == 0) {
							result.push(0);
						}
						else {
							result.push(record.data.value3);
						}
						return result;
					},
					yAxis: 2
				},
				{
					plot: 'spline',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (record.data.value4 == null || record.data.value4 == 0) {
							result.push(0);
						}
						else {
							result.push(record.data.value4);
						}
						return result;
					},
					yAxis: 3
				}
			],
			chartConfig: {
				chart: {
					marginLeft: 10,
					marginRight: 10,
					alignTicks: false
				},
				rangeSelector: {
					selected: 5
				},
				title: { text: '' },
				yAxis: [
					{
						title: { text: '' },
						height: '25%',
						lineWidth: 2
					},
					{
						title: { text: '' },
						top: '25%',
						height: '25%',
						lineWidth: 1
					},
					{
						title: { text: '' },
						top: '50%',
						height: '25%',
						lineWidth: 1
					},
					{
						title: { text: '' },
						top: '75%',
						height: '25%',
						lineWidth: 1
					}
				]
			}
		},
		DataFiveFields: {
			series: [
				{
					plot: 'spline',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (record.data.value == null || record.data.value == 0) {
							result.push(0);
						}
						else {
							result.push(record.data.value);
						}
						return result;
					}
				},
				{
					plot: 'spline',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (record.data.value2 == null || record.data.value2 == 0) {
							result.push(0);
						}
						else {
							result.push(record.data.value2);
						}
						return result;
					},
					yAxis: 1
				},
				{
					plot: 'spline',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (record.data.value3 == null || record.data.value3 == 0) {
							result.push(0);
						}
						else {
							result.push(record.data.value3);
						}
						return result;
					},
					yAxis: 2
				},
				{
					plot: 'spline',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (record.data.value4 == null || record.data.value4 == 0) {
							result.push(0);
						}
						else {
							result.push(record.data.value4);
						}
						return result;
					},
					yAxis: 3
				},
				{
					plot: 'spline',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (record.data.value5 == null || record.data.value5 == 0) {
							result.push(0);
						}
						else {
							result.push(record.data.value5);
						}
						return result;
					},
					yAxis: 4
				}
			],
			chartConfig: {
				chart: {
					marginLeft: 10,
					marginRight: 10,
					alignTicks: false
				},
				rangeSelector: {
					selected: 5
				},
				title: { text: '' },
				yAxis: [
					{
						title: { text: '' },
						height: '25%',
						lineWidth: 2
					},
					{
						title: { text: '' },
						top: '20%',
						height: '20%',
						lineWidth: 1
					},
					{
						title: { text: '' },
						top: '40%',
						height: '20%',
						lineWidth: 1
					},
					{
						title: { text: '' },
						top: '60%',
						height: '20%',
						lineWidth: 1
					},
					{
						title: { text: '' },
						top: '80%',
						height: '20%',
						lineWidth: 1
					}
				]
			}
		},
		OhlcData: {
			series: [
				{
					plot: 'candlestick',
					name: 'Price',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (record.data.open == null || record.data.open == 0) {
							result.push(null);
						}
						else {
							result.push(record.data.open);
						}
						if (record.data.high == null || record.data.high == 0) {
							result.push(null);
						}
						else {
							result.push(record.data.high);
						}
						if (record.data.low == null || record.data.low == 0) {
							result.push(null);
						}
						else {
							result.push(record.data.low);
						}
						if (record.data.close == null || record.data.close == 0) {
							result.push(null);
						}
						else {
							result.push(record.data.close);
						}
						return result;
					}
				}
			],
			chartConfig: {
				chart: {
					marginLeft: 10,
					marginRight: 10,
					alignTicks: false
				},
				rangeSelector: {
					selected: 5
				},
				title: { text: '' },
				yAxis: [
					{
						title: { text: '' },
						height: '100%',
						lineWidth: 2
					}
				]
			}
		},
		OhlcvData: {
			series: [
				{
					plot: 'candlestick',
					name: 'Price',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (record.data.open == null || record.data.open == 0) {
							result.push(null);
						}
						else {
							result.push(record.data.open);
						}
						if (record.data.high == null || record.data.high == 0) {
							result.push(null);
						}
						else {
							result.push(record.data.high);
						}
						if (record.data.low == null || record.data.low == 0) {
							result.push(null);
						}
						else {
							result.push(record.data.low);
						}
						if (record.data.close == null || record.data.close == 0) {
							result.push(null);
						}
						else {
							result.push(record.data.close);
						}
						return result;
					}
				},
				{
					plot: 'column',
					name: 'Volume',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (record.data.volume == null || record.data.volume == 0) {
							result.push(null);
						}
						else {
							result.push(record.data.volume);
						}
						return result;
					},
					yAxis: 1
				}
			],
			chartConfig: {
				chart: {
					marginLeft: 10,
					marginRight: 10,
					alignTicks: false
				},
				rangeSelector: {
					selected: 5
				},
				title: { text: '' },
				yAxis: [
					{
						title: { text: '' },
						height: '70%',
						lineWidth: 2
					},
					{
						title: { text: '' },
						top: '70%',
						height: '30%',
						lineWidth: 2
					}
				]
			}
		},
		OhlcvOpenInterestData: {
			series: [
				{
					plot: 'candlestick',
					name: 'Price',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (record.data.open == null || record.data.open == 0) {
							result.push(null);
						}
						else {
							result.push(record.data.open);
						}
						if (record.data.high == null || record.data.high == 0) {
							result.push(null);
						}
						else {
							result.push(record.data.high);
						}
						if (record.data.low == null || record.data.low == 0) {
							result.push(null);
						}
						else {
							result.push(record.data.low);
						}
						if (record.data.close == null || record.data.close == 0) {
							result.push(null);
						}
						else {
							result.push(record.data.close);
						}
						return result;
					}
				},
				{
					plot: 'column',
					name: 'Volume',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (record.data.volume == null || record.data.volume == 0) {
							result.push(null);
						}
						else {
							result.push(record.data.volume);
						}
						return result;
					},
					yAxis: 1
				},
				{
					plot: 'line',
					name: 'OpenInterest',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (record.data.openInterest == null || record.data.openInterest == 0) {
							result.push(null);
						}
						else {
							result.push(record.data.openInterest);
						}
						return result;
					},
					yAxis: 2
				}
			],
			chartConfig: {
				chart: {
					marginLeft: 10,
					marginRight: 10,
					alignTicks: false
				},
				rangeSelector: {
					selected: 5
				},
				title: { text: '' },
				yAxis: [
					{
						title: { text: '' },
						height: '50%',
						lineWidth: 2
					},
					{
						title: { text: '' },
						top: '50%',
						height: '25%',
						lineWidth: 2
					},
					{
						title: { text: '' },
						top: '75%',
						height: '25%',
						lineWidth: 2
					}
				]
			}
		},
		SGXData: {
			series: [
				{
					plot: 'candlestick',
					name: 'Price',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (record.data.open == null || record.data.open == 0) {
							result.push(null);
						}
						else {
							result.push(record.data.open);
						}
						if (record.data.high == null || record.data.high == 0) {
							result.push(null);
						}
						else {
							result.push(record.data.high);
						}
						if (record.data.low == null || record.data.low == 0) {
							result.push(null);
						}
						else {
							result.push(record.data.low);
						}
						if (record.data.close == null || record.data.close == 0) {
							result.push(null);
						}
						else {
							result.push(record.data.close);
						}
						return result;
					}
				},
				{
					plot: 'line',
					name: 'Settle',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (record.data.settle == null || record.data.settle == 0) {
							result.push(null);
						}
						else {
							result.push(record.data.settle);
						}
						return result;
					},
					yAxis: 1
				},
				{
					plot: 'column',
					name: 'Volume',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (record.data.volume == null || record.data.volume == 0) {
							result.push(null);
						}
						else {
							result.push(record.data.volume);
						}
						return result;
					},
					yAxis: 2
				},
				{
					plot: 'line',
					name: 'OpenInterest',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (record.data.openInterest == null || record.data.openInterest == 0) {
							result.push(null);
						}
						else {
							result.push(record.data.openInterest);
						}
						return result;
					},
					yAxis: 3
				}
			],
			chartConfig: {
				chart: {
					marginLeft: 10,
					marginRight: 10,
					alignTicks: false
				},
				rangeSelector: {
					selected: 5
				},
				title: { text: '' },
				yAxis: [
					{
						title: { text: '' },
						height: '40%',
						lineWidth: 2
					},
					{
						title: { text: '' },
						top: '40%',
						height: '20%',
						lineWidth: 2
					},
					{
						title: { text: '' },
						top: '60%',
						height: '20%',
						lineWidth: 2
					},
					{
						title: { text: '' },
						top: '80%',
						height: '20%',
						lineWidth: 2
					}
				]
			}
		},
		YAHOOData: {
			series: [
				{
					plot: 'candlestick',
					name: 'Price',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (record.data.open == null || record.data.open == 0) {
							result.push(null);
						}
						else {
							result.push(record.data.open);
						}
						if (record.data.high == null || record.data.high == 0) {
							result.push(null);
						}
						else {
							result.push(record.data.high);
						}
						if (record.data.low == null || record.data.low == 0) {
							result.push(null);
						}
						else {
							result.push(record.data.low);
						}
						if (record.data.close == null || record.data.close == 0) {
							result.push(null);
						}
						else {
							result.push(record.data.close);
						}
						return result;
					}
				},
				{
					plot: 'column',
					name: 'Volume',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (record.data.volume == null || record.data.volume == 0) {
							result.push(null);
						}
						else {
							result.push(record.data.volume);
						}
						return result;
					},
					yAxis: 1
				},
				{
					plot: 'line',
					name: 'AdjustedClose',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (record.data.adjustedClose == null || record.data.adjustedClose == 0) {
							result.push(null);
						}
						else {
							result.push(record.data.adjustedClose);
						}
						return result;
					},
					yAxis: 2
				}
			],
			chartConfig: {
				chart: {
					marginLeft: 10,
					marginRight: 10,
					alignTicks: false
				},
				rangeSelector: {
					selected: 5
				},
				title: { text: '' },
				yAxis: [
					{
						title: { text: '' },
						height: '60%',
						lineWidth: 2
					},
					{
						title: { text: '' },
						top: '60%',
						height: '20%',
						lineWidth: 2
					},
					{
						title: { text: '' },
						top: '80%',
						height: '20%',
						lineWidth: 2
					}
				]
			}
		}
	}
});