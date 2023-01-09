using System.Runtime.InteropServices;

namespace cyxx
{
	public class Program
	{
		public static void Main()
		{
			// Simple case
			print(Solution.Two(100, 1, 2));

			// Test case
			print(Solution.Two(4_000_000, 1, 2));

			// classic fibonacci
			print(Solution.Two(100, debug: true));

			// Fun fibonacci patterns
			print(Solution.Two(120, 2, 4, true));
			print(Solution.Two(120, 7, 3, true));
		}

		#region util
		public static void print(object arg)
		{
			Console.WriteLine(arg.ToString());
		}
		#endregion
	}

	public static class Solution
	{
		#region Problem
		/*
		 *		Each new term in the Fibonacci sequence is generated
		 *			by adding the previous two terms. By starting
		 *			with 1 and 2, the first 10 terms will be:
		 *			
		 *				1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
		 *		
		 *		By considering the terms in the Fibonacci sequence
		 *			whose values do not exceed four million, find
		 *			the sum of the even-valued terms.
		 */
		#endregion
		#region Solution
		/*
		 *		Function `Two` takes up to four parameters
		 *			fibbonacciMax: the highest number that will be checked
		 *			seedA: the initial value of a
		 *			seedB: the inital value of b
		 *			debug: set to true to print all numbers in the sequence
		 *			
		 *			
		 *		The Fibonacci sequence is generated as follows:
		 *			var a, b, c
		 *			while (true):
		 *				c = a + b
		 *				a = b
		 *				b = c
		 *				
		 *		Returns the sum of all even numbers in the sequence.
		 */
		#endregion
		public static int Two(int fibbonacciMax, int seedA = 0, int seedB = 1, bool debug = false)
		{
			int a = seedA, b = seedB, c;
			int[] patterns = { 2 };
			int sum = 0;

			while (a < fibbonacciMax)
			{
				if (debug)
					Console.Write($"{a}, ");

				c = a + b;
				a = b;
				b = c;

				foreach (var pattern in patterns)
				{
					if (a % pattern != 0) continue;
					sum += a;
					break;
				}
			}
			if (debug)
				Console.Write("= ");
			return sum;
		}
	}
}