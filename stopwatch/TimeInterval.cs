using System;
using System.Collections.Generic;

namespace stopwatch
{

	class TimeInterval {
		readonly private long _minimum;
		readonly private long _maximum;

		public long getTimeInterval() {
			
			return this._maximum-this._minimum;
		
		}
	
		public TimeInterval(long minimum, long maximum) {
			
			this._minimum = minimum;
			this._maximum = maximum;

		}
	}
	
}
