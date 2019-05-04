using System;
using System.Collections.Generic;

namespace stopwatch
{
	class Program
	{
		public static void showStopWatch(StopWatch stopWatch) {
			foreach(long timeInterval in stopWatch.TimeIntervals) {
				Console.WriteLine(" -> " + timeInterval.ToString());
			}
		}

		public static StopWatch fillStopWatch(StopWatch stopWatch) {
			ConsoleKeyInfo input;
			long min, max;

			do {
				Console.Write("Press Enter to start -> ");
				input = Console.ReadKey ();
				min = DateTime.Now.Ticks;
				Console.Write("min = " + min.ToString() + "\n");

				Console.Write("Press Enter to finish ->");
				input = Console.ReadKey ();
				max = DateTime.Now.Ticks;
				Console.Write("max = " + max.ToString() + "\n");

				TimeInterval currentTimeInterval = new TimeInterval(min, max);
				stopWatch.insertTimeInterval(currentTimeInterval.getTimeInterval());

			} while (input.Key.ToString() != "Q");

			return stopWatch;
		}

		public static void Main (string[] args)
		{
			
			StopWatch stopWatch = new StopWatch ();

			Console.WriteLine ("*** StopWatch Console App ***\n\n\n Press <Q> for exit\n \n ");

			stopWatch = fillStopWatch (stopWatch);

			Console.WriteLine ("\n List of Time Intervals: \n");

			showStopWatch (stopWatch);

		}
	}
}
