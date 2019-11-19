using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulier
{
	class Program
	{
		static void Main(string[] args)
		{
			PrimeNumber PNumber = new PrimeNumber();
			
			long sum = 0;
			int limit = 2000000;
			for (int i=2; i <= limit; i++)
			{	
				if (PNumber.isPrime(i))
				{
					sum += i;
				}
			}
			Console.WriteLine("Sum of numbers below 2000000 is " + sum);
			Console.ReadLine();
		}
	}
/**************************************************************************************************************************************/
	class PrimeNumber
	{
  // The function used to determine whether the number is prime.
  
		public bool isPrime(int number)
		{
			if (number == 1) return false;
			if (number == 2) return true;
			var limit = Math.Ceiling(Math.Sqrt(number));
			for (int i = 2; i <= limit; ++i)
			{
				if (number % i == 0) return false;
			}
			return true;
		}
	}
}
