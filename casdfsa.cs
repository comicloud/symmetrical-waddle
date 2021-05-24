using System;
using System.Diagnostics;
using System.Numerics;

namespace Dates {
	class sundays {
	
		public static void Main(string[] args) {// this is our static main method, which is the entry point of the application
			new sundays().solve();
		}
		
		public void solve() {
			Stopwatch clock = Stopwatch.StartNew();
			
			int sundays = 0;
			
			for (int year = 1901; year <= 2000; year++) {//here we tell the machine our first timeframe of years
				for (int month = 1; month <= 12; month++) {// here we tell it the second timeframe of months
					if ((new DateTime(year, month, 1)).DayOfWeek == DayOfWeek.Sunday) {// finally here we tell it to add 1 every time the first of the month is a sunday
						sundays++;
					}
				}
			}
			
			clock.Stop();
			Console.WriteLine("There are {0} sundays that land on the first", sundays);// heres where the machine returns the ammount of sundays that are the first of the month in this set period
		}
	
	}
}
