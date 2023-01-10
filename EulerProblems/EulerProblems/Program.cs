using System.Diagnostics;
using System.Security.Principal;

namespace cyxx
{
	public class Program
	{
		// https://projecteuler.net/problem=9
		#region Problem
		/*
		 *		A Pythagorean triplet is a set of three natural numbers, `a < b < c`, for which,
		 *				`a^2 + b^2 = c^2`
		 *				
		 *		For example, 32 + 42 = 9 + 16 = 25 = 52.
		 *		There exists exactly one Pythagorean triplet for which `a + b + c = 1000`.
		 *		Find the product `a * b * c`.
		 */
		#endregion
		#region Solution
		/*
		 *		Function `Nine` takes one parameter, and one optional parameter
		 *			n: the target number to search for where 
		 *				`a^2 + b^2 == c^2 && a + b + c == n`
		 *			debug: if true, prints additional information to the console.
		 *				
		 *		Function brute forces the solution, and simply immediate 
		 *			continues the loop if any condition is rejected
		 *			
		 *		Returns the product of the pythagorean triplet, or -1 if
		 *			no triplet was found in the natural numbers 0..<n
		 */
		#endregion

		private static int Nine(int n, bool debug = false)
		{
			Debug.Assert(n >= 3, "Because a<b<c, n cannot be lower than 3");

			for (int a = 0; a < n - 3; ++a)
				for (int b = a + 1; b < n - 2; ++b)
					for (int c = b + 1; c < n - 1; ++c)
					{
						if (a + b + c != n || sqr(a) + sqr(b) != sqr(c))
							continue;

						if (debug) Console.Write("{0}, {1}, {2}: ", a, b, c);
						return a * b * c;
					}

			return -1;
		}

		private static int sqr(int n) => n * n;

		public static void Main()
		{
			// Sample case
			Console.WriteLine(Nine(12, debug: true));

			// Test Case
			Console.WriteLine(Nine(1000, debug: true));
		}
	}
}