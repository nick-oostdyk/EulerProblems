namespace cyxx
{
	public class Program
	{
		public static void Main()
		{
			// Simple case
			foreach (var num in Solution.Three(13195))
				Console.Write(num + " ");
			Console.WriteLine(": " + Solution.Three(13195).Max());

			// Test case
			foreach (var num in Solution.Three(600851475143))
				Console.Write(num + " ");
			Console.WriteLine(": " + Solution.Three(600851475143).Max());
		}
	}

	public static class Solution
	{
		#region Problem
		/*
		 *		The prime factors of 13195 are 5, 7, 13 and 29.
		 *			What is the largest prime factor 
		 *			of the number 600851475143 ?
		 */
		#endregion
		#region Solution
		/*
		 *	Function `Three` takes a single parameter
		 *		composite: the number to be broken down into prime factors
		 *		
		 *		Returns an array containing the prime factors of the input
		 */
		#endregion
		public static long[] Three(long composite)
		{
			var factors = new List<long>();
			var n = composite;

			for (int i = 2; i < MathF.Sqrt(composite); ++i)
				while (n % i == 0)
				{
					factors.Add(i);
					n /= i;
				}
			if (n > 2)
				factors.Add(n);

			return factors.ToArray();
		}
	}
}