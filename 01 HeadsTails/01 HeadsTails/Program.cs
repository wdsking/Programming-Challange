using System;

namespace _01_HeadsTails
{
    class Program
    {
		static void Main(string[] args)
		{
			int index = 0;
			while (true)
			{
				Console.Clear();
				Console.WriteLine("Wybierz jedno\n1. Orzel\n2. Reszka\n3. Wyjdz");
				index = ReadInt();
				if (index == 3) return;
				if(Coinflip(index))
				{
					Console.WriteLine("Wygrales!");
				}else
				{
					Console.WriteLine("Przegrales :(");
				}
				Console.WriteLine("Wcisnij dowolny klawisz");
				Console.ReadKey();
			}
		}
		static bool Coinflip(int index)
		{
			return new Random().Next(1, 3) == index ? true : false;
		}
		static int ReadInt()
		{
			return int.Parse(Console.ReadLine());
		}
    }
}
