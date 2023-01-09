using System.Runtime.InteropServices;

namespace cyxx
{
	public class Program
	{
		// https://projecteuler.net/problem=6
		#region Problem
		/*
		 *		The sum of the squares of the first ten natural numbers is,
		 *			
		 *			(1 ** 2) + (2 ** 2) + (3 ** 2) + .. + (10 ** 2) = 385
		 *			
		 *		The square of the sum of the first ten natural numbers is,
		 *			
		 *			(1 + 2 + 3 + .. + 10) ** 2 = 55 ** 2 = 3025
		 *			
		 *		Hence the difference between the sum of the squares of the 
		 *			first ten natural numbers and the square of the sum is
		 *			
		 *			3025 - 385 = 2640
		 *			
		 *		Find the difference between the sum of the squares of the first 
		 *			one hundred natural numbers and the square of the sum.
		 */
		#endregion
		#region Solution
		/*
		 *		Function `Six` takes one parameter
		 *			n: iterates up to and including this number
		 *			
		 *		Passes the number of iterations into two helper functions,
		 *			_sumOfSqrs(): 
		 *				sums the square of each number up to and including n
		 *					1..n => value += i * i
		 *					ret value
		 *					
		 *			_sqrOfSums():
		 *				sums all values to and including n, then squares them
		 *					1..n => value += i 
		 *					ret value * value
		 *					
		 *		Returns the difference between the two values (sqrOfSums - sumOfSqrs)
		 */
		#endregion

		public static int Six(int n) => _sqrOfSums(n) - _sumOfSqrs(n);

		private static int _sumOfSqrs(int n)
		{
			int result = 0;
			for (int i = 1; i <= n; ++i)
				result += i * i;
			return result;
		}

		private static int _sqrOfSums(int n)
		{
			int result = 0;
			for (int i = 1; i <= n; ++i)
				result += i;
			return result * result;
		}

		public static void Main()
		{
			// Simple case
			Console.WriteLine(Six(10));

			// Test case
			Console.WriteLine(Six(100));
		}
	}
}