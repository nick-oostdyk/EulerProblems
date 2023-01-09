using System.Diagnostics.SymbolStore;

namespace cyxx
{
	public class Program
	{
		// https://projecteuler.net/problem=7
		#region Problem
		/*
		 *		By listing the first six prime numbers: 
		 *				2, 3, 5, 7, 11, and 13, 
		 *			we can see that the 6th prime is 13.
		 *		
		 *		What is the 10 001st prime number?
		 */
		#endregion
		#region Solution
		/*
		 *		Function `Seven` takes 1 parmeter
		 *			index: the nth prime number to return
		 *			
		 *		calls the recursive function `_isPrime` to test if a number is prime
		 *		Indexing begins at 0, which returns the first prime number: 2
		 *			
		 *		Returns the nth prime number
		 */
		#endregion
		public static int Seven(int index)
		{
			int i = 0, j = 2;
			int prime = 2;
			while (i < index)
			{
				do
					++j;
				while (!_isPrime(j));
 
				prime = j;
				++i;
			}
			return prime;
		}

		private static bool _isPrime(int n) => _isPrime(2, n, (int)Math.Round(Math.Sqrt(n)));
		private static bool _isPrime(int i, int n, int lim)
		{
			if (n == 0 || n == 1) return false;
			if (i > lim) return true;
			if (n % i == 0) return false;
			return _isPrime(++i, n, lim);
		}

		public static void Main()
		{
			// prints first 5 primes
			for (int i = 0; i < 5; ++i)
				Console.Write(" " + Seven(i));
			Console.Write(" .. ");

			// Prints the 10th prime number
			Console.WriteLine(Seven(10));

			// test case
			Console.Write(Seven(10_000));
		}
	}
}