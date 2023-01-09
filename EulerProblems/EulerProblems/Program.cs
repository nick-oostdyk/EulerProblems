using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace cyxx
{
	public class Program
	{
		// https://projecteuler.net/problem=5
		#region Problem
		/*
		 *		05. Smallest Multiple:
		 *		
		 *		2520 is the smallest number that can be divided by each 
		 *			of the numbers from 1 to 10 without any remainder.
		 *		
		 *		What is the smallest positive number that is evenly 
		 *			divisible by all of the numbers from 1 to 20?
		 */
		#endregion

		#region Solution
		/*
		 *		Function `Five` takes 1 parameter
		 *			n: the max number to check all preceding numbers as factors against
		 *			
		 *		Returns the smallest number where all numbers 1..n are factors
		 */
		#endregion
		private static int Five(int n)
		{
			int ret = 1;
			while (true)
				for (int i = 1; i <= n; ++i)
				{
					if (ret % i == 0)
					{
						if (i == n)
							return ret;
						continue;
					}
					++ret;
					break;
				}
		}

		public static void Main()
		{
			// Simple case
			Console.WriteLine(Five(10));

			// Test case
			Console.WriteLine(Five(20));
		}
	}
}