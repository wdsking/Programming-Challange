﻿using System;

namespace Problem_2
{
/*
Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
*/
    class Program
    {
        static void Main(string[] args)
        {
			int sum = 0;
			for (int i = 0;;i++)
			{
				int number = Fibbonaci(i);
				if (number > 4000000) break;
				if (number%2==0)
				{
					sum += number;
				}
			}
			Console.WriteLine(sum);
			Console.ReadKey();
        }
		static int Fibbonaci(int position)
		{
			if(position == 0 || position == 1)
			{
				return 1;
			}
			else
			{
				return Fibbonaci(position - 1) + Fibbonaci(position - 2);
			}
		}
    }
}
