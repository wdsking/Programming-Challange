using System;

namespace Problem_3
{
/*
The prime factors of 13195 are 5, 7, 13 and 29.
What is the largest prime factor of the number 600851475143 ?
*/
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine(maxPrimeFactors(600851475143));
			Console.ReadKey();
        }
	
		static long maxPrimeFactors(long n)
		{
			long maxPrime = -1;
			while (n % 2 == 0)
			{
				maxPrime = 2;
				n >>= 1;
			}
			for (int i = 3; i <= Math.Sqrt(n); i += 2)
			{
				while (n % i == 0)
				{
					maxPrime = i;
					n = n / i;
				}
			}
			if (n > 2)
				maxPrime = n;

			return maxPrime;
		}
	}
}
