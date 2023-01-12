using cyxx.Extentions;
using System.Reflection.Metadata.Ecma335;

namespace cyxx
{
	public class Program
	{
		// https://projecteuler.net/problem=10
		#region Problem
		/*
		 *		The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
		 *		Find the sum of all the primes below two million.
		 */
		#endregion
		#region Solution
		/*
		 *		uses an extention method "IsPrime" from my problem 07 solution.
		 *			https://github.com/nick-oostdyk/EulerProblems/blob/07/EulerProblems/EulerProblems/Program.cs
		 *	
		 *		
		 */
		#endregion

		public static long Ten(int n)
		{
			long sum = 0;

			for (int i = 0; i < n; ++i)
			{
				if (!i.IsPrime()) continue;
				sum += i;
			}

			return sum;
		}

		public static void Main()
		{
			// Sample Case
			Console.WriteLine(Ten(10));

			// Test Case
			Console.WriteLine(Ten(2_000_000));
		}
	}
}

namespace cyxx.Extentions
{
	public static class cyxxExtentions
	{
		public static bool IsPrime(this int n) => _isPrime(2, n, (int)Math.Round(Math.Sqrt(n)));
		private static bool _isPrime(int i, int n, int lim)
		{
			if (n == 0 || n == 1) return false;
			if (i > lim) return true;
			if (n % i == 0) return false;
			return _isPrime(++i, n, lim);
		}
	}
}