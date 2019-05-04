using System;
using System.Collections.Generic;

namespace stopwatch
{

	class StopWatch {
		private List<long> _timeIntervals = new List<long>();

		public List<long> TimeIntervals {
			get { return this._timeIntervals; }
		}

		public void insertTimeInterval(long timeInterval) {
			this._timeIntervals.Add (timeInterval);
		}
	}
	
}
