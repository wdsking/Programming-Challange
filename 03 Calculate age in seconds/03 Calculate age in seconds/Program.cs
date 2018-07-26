using System;

namespace _03_Calculate_age_in_seconds
{
    class Program
    {
        static void Main(string[] args)
        {
			int age = 0;
			int days = 0;
			Console.WriteLine("Podaj swoj wiek");
			age = int.Parse(Console.ReadLine());

			for(int i = 0; i<age;i++)
			{
				if(isLeapYear(DateTime.Now.Year-age))
				{
					days += 366;
				}else
				{
					days += 365;
				}
			}
			Console.WriteLine("Zyjesz juz " + DaysToSeconds(days) + " sekund!");
			Console.ReadKey();
		}
		static bool isLeapYear(int year)
		{
			if(year%4==0)
			{
				if(year%100==0)
				{
					if(year%400==0)
					{
						return true;
					}
					return false;
				}
				return true;
			}
			return false;
		}
		static int DaysToSeconds(int days)
		{
			return 24 * 60 * 60 * days;
		}
    }
}
