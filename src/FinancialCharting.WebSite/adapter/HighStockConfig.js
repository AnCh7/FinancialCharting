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
					dataGrouping: { enabled: false },
					connectNulls: true,
					plot: 'spline',
					getData: function(record) {
						var result = [];
						debugger;
						result.push(record.data.date_unix);
						if (typeof record.data.value != 'undefined' && record.data.value != '') {
							result.push(record.data.value);
						}
						else {
							result.push(null);
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
				yAxis: [
					{
						height: '100%',
						lineWidth: 2
					}
				],
			}
		},
		DataTwoFields: {
			series: [
				{
					dataGrouping: { enabled: false },
					connectNulls: true,
					plot: 'spline',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (typeof record.data.value != 'undefined' && record.data.value != '') {
							result.push(record.data.value);
						}
						else {
							result.push(null);
						}
						return result;
					}
				},
				{
					dataGrouping: { enabled: false },
					connectNulls: true,
					plot: 'spline',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (typeof record.data.value2 != 'undefined' && record.data.value2 != '') {
							result.push(record.data.value2);
						}
						else {
							result.push(null);
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
				yAxis: [
					{
						height: '50%',
						lineWidth: 2
					},
					{
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
					dataGrouping: { enabled: false },
					connectNulls: true,
					plot: 'spline',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (typeof record.data.value != 'undefined' && record.data.value != '') {
							result.push(record.data.value);
						}
						else {
							result.push(null);
						}
						return result;
					}
				},
				{
					dataGrouping: { enabled: false },
					connectNulls: true,
					plot: 'spline',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (typeof record.data.value2 != 'undefined' && record.data.value2 != '') {
							result.push(record.data.value2);
						}
						else {
							result.push(null);
						}
						return result;
					},
					yAxis: 1
				},
				{
					dataGrouping: { enabled: false },
					connectNulls: true,
					plot: 'spline',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (typeof record.data.value3 != 'undefined' && record.data.value3 != '') {
							result.push(record.data.value3);
						}
						else {
							result.push(null);
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
				yAxis: [
					{
						height: '50%',
						lineWidth: 2
					},
					{
						top: '50%',
						height: '25%',
						lineWidth: 1
					},
					{
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
					dataGrouping: { enabled: false },
					connectNulls: true,
					plot: 'spline',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (typeof record.data.value != 'undefined' && record.data.value != '') {
							result.push(record.data.value);
						}
						else {
							result.push(null);
						}
						return result;
					}
				},
				{
					dataGrouping: { enabled: false },
					connectNulls: true,
					plot: 'spline',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (typeof record.data.value2 != 'undefined' && record.data.value2 != '') {
							result.push(record.data.value2);
						}
						else {
							result.push(null);
						}
						return result;
					},
					yAxis: 1
				},
				{
					dataGrouping: { enabled: false },
					connectNulls: true,
					plot: 'spline',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (typeof record.data.value3 != 'undefined' && record.data.value3 != '') {
							result.push(record.data.value3);
						}
						else {
							result.push(null);
						}
						return result;
					},
					yAxis: 2
				},
				{
					dataGrouping: { enabled: false },
					connectNulls: true,
					plot: 'spline',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (typeof record.data.value4 != 'undefined' && record.data.value4 != '') {
							result.push(record.data.value4);
						}
						else {
							result.push(null);
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
				yAxis: [
					{
						height: '25%',
						lineWidth: 2
					},
					{
						top: '25%',
						height: '25%',
						lineWidth: 1
					},
					{
						top: '50%',
						height: '25%',
						lineWidth: 1
					},
					{
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
					dataGrouping: { enabled: false },
					connectNulls: true,
					plot: 'spline',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (typeof record.data.value != 'undefined' && record.data.value != '') {
							result.push(record.data.value);
						}
						else {
							result.push(null);
						}
						return result;
					}
				},
				{
					dataGrouping: { enabled: false },
					connectNulls: true,
					plot: 'spline',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (typeof record.data.value2 != 'undefined' && record.data.value2 != '') {
							result.push(record.data.value2);
						}
						else {
							result.push(null);
						}
						return result;
					},
					yAxis: 1
				},
				{
					dataGrouping: { enabled: false },
					connectNulls: true,
					plot: 'spline',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (typeof record.data.value3 != 'undefined' && record.data.value3 != '') {
							result.push(record.data.value3);
						}
						else {
							result.push(null);
						}
						return result;
					},
					yAxis: 2
				},
				{
					dataGrouping: { enabled: false },
					connectNulls: true,
					plot: 'spline',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (typeof record.data.value4 != 'undefined' && record.data.value4 != '') {
							result.push(record.data.value4);
						}
						else {
							result.push(null);
						}
						return result;
					},
					yAxis: 3
				},
				{
					dataGrouping: { enabled: false },
					connectNulls: true,
					plot: 'spline',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (typeof record.data.value5 != 'undefined' && record.data.value5 != '') {
							result.push(record.data.value5);
						}
						else {
							result.push(null);
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
				yAxis: [
					{
						height: '25%',
						lineWidth: 1
					},
					{
						top: '20%',
						height: '20%',
						lineWidth: 1
					},
					{
						top: '40%',
						height: '20%',
						lineWidth: 1
					},
					{
						top: '60%',
						height: '20%',
						lineWidth: 1
					},
					{
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
					dataGrouping: { enabled: false },
					connectNulls: true,
					plot: 'candlestick',
					name: 'Price',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (typeof record.data.open != 'undefined' && record.data.open != '' &&
							typeof record.data.high != 'undefined' && record.data.high != '' &&
							typeof record.data.low != 'undefined' && record.data.low != '' &&
							typeof record.data.close != 'undefined' && record.data.close != '') {
							result.push(record.data.open);
							result.push(record.data.high);
							result.push(record.data.low);
							result.push(record.data.close);
						}
						else {
							result.push(null);
							result.push(null);
							result.push(null);
							result.push(null);
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
				yAxis: [
					{
						height: '100%',
						lineWidth: 2
					}
				]
			}
		},
		OhlcvData: {
			series: [
				{
					dataGrouping: {enabled: false},
					connectNulls: true,
					plot: 'candlestick',
					name: 'Price',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (typeof record.data.open != 'undefined' && record.data.open != '' &&
							typeof record.data.high != 'undefined' && record.data.high != '' &&
							typeof record.data.low != 'undefined' && record.data.low != '' &&
							typeof record.data.close != 'undefined' && record.data.close != '') {
							result.push(record.data.open);
							result.push(record.data.high);
							result.push(record.data.low);
							result.push(record.data.close);
						}
						else {
							result.push(null);
							result.push(null);
							result.push(null);
							result.push(null);
						}

						return result;
					}
				},
				{
					dataGrouping: {enabled: false},
					connectNulls: true,
					plot: 'column',
					name: 'Volume',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (typeof record.data.volume != 'undefined' && record.data.volume != '') {
							result.push(record.data.volume);
						}
						else {
							result.push(null);
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
				yAxis: [
					{
						height: '70%',
						lineWidth: 2
					},
					{
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
					dataGrouping: { enabled: false },
					connectNulls: true,
					plot: 'candlestick',
					name: 'Price',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (typeof record.data.open != 'undefined' && record.data.open != '' &&
							typeof record.data.high != 'undefined' && record.data.high != '' &&
							typeof record.data.low != 'undefined' && record.data.low != '' &&
							typeof record.data.close != 'undefined' && record.data.close != '') {
							result.push(record.data.open);
							result.push(record.data.high);
							result.push(record.data.low);
							result.push(record.data.close);
						}
						else {
							result.push(null);
							result.push(null);
							result.push(null);
							result.push(null);
						}
						return result;
					}
				},
				{
					dataGrouping: { enabled: false },
					connectNulls: true,
					plot: 'column',
					name: 'Volume',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (typeof record.data.volume != 'undefined' && record.data.volume != '') {
							result.push(record.data.volume);
						}
						else {
							result.push(null);
						}
						return result;
					},
					yAxis: 1
				},
				{
					dataGrouping: { enabled: false },
					connectNulls: true,
					plot: 'line',
					name: 'OpenInterest',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (typeof record.data.openInterest != 'undefined' && record.data.openInterest != '') {
							result.push(record.data.openInterest);
						}
						else {
							result.push(null);
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
				yAxis: [
					{
						height: '50%',
						lineWidth: 2
					},
					{
						top: '50%',
						height: '25%',
						lineWidth: 2
					},
					{
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
					dataGrouping: { enabled: false },
					connectNulls: true,
					plot: 'candlestick',
					name: 'Price',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (typeof record.data.open != 'undefined' && record.data.open != '' &&
							typeof record.data.high != 'undefined' && record.data.high != '' &&
							typeof record.data.low != 'undefined' && record.data.low != '' &&
							typeof record.data.close != 'undefined' && record.data.close != '') {
							result.push(record.data.open);
							result.push(record.data.high);
							result.push(record.data.low);
							result.push(record.data.close);
						}
						else {
							result.push(null);
							result.push(null);
							result.push(null);
							result.push(null);
						}
						return result;
					}
				},
				{
					dataGrouping: { enabled: false },
					connectNulls: true,
					plot: 'line',
					name: 'Settle',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (typeof record.data.settle != 'undefined' && record.data.settle != '') {
							result.push(record.data.settle);
						}
						else {
							result.push(null);
						}
						return result;
					},
					yAxis: 1
				},
				{
					dataGrouping: { enabled: false },
					connectNulls: true,
					plot: 'column',
					name: 'Volume',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (typeof record.data.volume != 'undefined' && record.data.volume != '') {
							result.push(record.data.volume);
						}
						else {
							result.push(null);
						}
						return result;
					},
					yAxis: 2
				},
				{
					dataGrouping: { enabled: false },
					connectNulls: true,
					plot: 'line',
					name: 'OpenInterest',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (typeof record.data.openInterest != 'undefined' && record.data.openInterest != '') {
							result.push(record.data.openInterest);
						}
						else {
							result.push(null);
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
				yAxis: [
					{
						height: '40%',
						lineWidth: 2
					},
					{
						top: '40%',
						height: '20%',
						lineWidth: 2
					},
					{
						top: '60%',
						height: '20%',
						lineWidth: 2
					},
					{
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
					dataGrouping: { enabled: false },
					connectNulls: true,
					plot: 'candlestick',
					name: 'Price',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (typeof record.data.open != 'undefined' && record.data.open != '' &&
							typeof record.data.high != 'undefined' && record.data.high != '' &&
							typeof record.data.low != 'undefined' && record.data.low != '' &&
							typeof record.data.close != 'undefined' && record.data.close != '') {
							result.push(record.data.open);
							result.push(record.data.high);
							result.push(record.data.low);
							result.push(record.data.close);
						}
						else {
							result.push(null);
							result.push(null);
							result.push(null);
							result.push(null);
						}
						return result;
					}
				},
				{
					dataGrouping: { enabled: false },
					connectNulls: true,
					plot: 'column',
					name: 'Volume',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (typeof record.data.volume != 'undefined' && record.data.volume != '') {
							result.push(record.data.volume);
						}
						else {
							result.push(null);
						}
						return result;
					},
					yAxis: 1
				},
				{
					dataGrouping: { enabled: false },
					connectNulls: true,
					plot: 'line',
					name: 'AdjustedClose',
					getData: function(record) {
						var result = [];
						result.push(record.data.date_unix);
						if (typeof record.data.adjustedClose != 'undefined' && record.data.adjustedClose != '') {
							result.push(record.data.adjustedClose);
						}
						else {
							result.push(null);
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
				yAxis: [
					{
						height: '60%',
						lineWidth: 2
					},
					{
						top: '60%',
						height: '20%',
						lineWidth: 2
					},
					{
						top: '80%',
						height: '20%',
						lineWidth: 2
					}
				]
			}
		}
	}
});