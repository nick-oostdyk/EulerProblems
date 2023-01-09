using System.Runtime.InteropServices;

namespace cyxx
{
	public class Program
	{
		#region Problem
		/*
		 *		A palindromic number reads the same both ways.
		 *			The largest palindrome made from the product 
		 *			of two 2-digit numbers is 9009 = 91 × 99.
		 *			
		 *		Find the largest palindrome made from the product 
		 *			of two 3-digit numbers.
		 */
		#endregion
		#region Solution
		/*
		 *	
		 */
		#endregion
		private static int Four(int min, int max)
		{
			int record = 0;
			for (int i = max; i >= min; --i)
				for (int j = i; j >= min; --j)
				{
					var product = i * j;
					if (!isPalindrome(product)) continue;
					if (product > record) record = product;
				}

			return record;
		}

		private static bool isPalindrome(int input)
		{
			var str_input = input.ToString();
			var reversed = str_input.ToCharArray();
			Array.Reverse(reversed);
			return str_input == new string(reversed);
		}

		public static void Main()
		{
			// Simple case
			Console.WriteLine(Four(10, 99));

			// Test case
			Console.WriteLine(Four(100, 999));
		}

	}
}