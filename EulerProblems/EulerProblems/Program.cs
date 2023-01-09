using System;
using System.Collections;
using System.Collections.Generic;

namespace cyxx
{
	public class Program
	{
		#region Problem
		/*
		 *     If we list all the natural numbers below 10 that are multiples 
		 *         of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples 
		 *         is 23. Find the sum of all the multiples of 3 or 5 below 1000.
		 */
		#endregion
		#region Solution
		/*
		 *		Function `one` takes at least two parameters.
		 *			The first parameter is n where 0..<n is checked for multiples in the pattern.
		 *			The second parameter is a variadic to take a list of numbers to check for multiples with.
		 *			
		 *			The function iterates `iterations` times, checking if a number 0..<n is a multiple of
		 *				any number passed in in args.
		 *				
		 *			Throws an Exception if no pattern is provided, or no iterations will run.
		 *			
		 *			Returns the sum of all numbers which follow the pattern.
		 */
		#endregion
		public static int One(int iterations, params int[] args)
		{
			if (iterations <= 0) throw new Exception("iterations must be greater than 0.");
			if (args.Length == 0) throw new Exception("Must provide at least 1 number to compare.");

			int workingSum = 0;
			for (int i = 0; i < iterations; ++i)
				foreach (var pattern in args)
				{
					if (i % pattern != 0) continue;
					workingSum += i;
					break;
				}
			return workingSum;
		}

		public static void Main()
		{
			// Simple Case
			// 3, 5, 6, 9 = 23
			Console.WriteLine(One(10, 3, 5));

			// Test Case
			// { 0..<1000 % 3 | 5 } = 233168
			Console.WriteLine(One(1000, 3, 5));

			// Example Cases

			// Console.WriteLine(One(0, 1)) // throws an exception - must iterate at least once
			// Console.WriteLine(One(10))   // throws an exception - must provide a pattern

			// 4, 8 = 12
			Console.WriteLine(One(10, 4));

			// 2, 3, 4, 6, 8, 9 = 32
			Console.WriteLine(One(10, 2, 3));

			// 5, 6, 7, 10, 12, 14, 15, 18 = 87
			Console.WriteLine(One(20, 5, 6, 7));
		}
	}
}