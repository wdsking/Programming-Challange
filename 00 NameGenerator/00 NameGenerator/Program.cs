using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace _00_NameGenerator
{
    class Program
    {
		static List<string> femaleNames = new List<string>();
		static List<string> maleNames = new List<string>();
		static List<string> surnames = new List<string>();
		static List<string> credentials = new List<string>();

		static void Main(string[] args)
        {
			Load();
			int index = 0;
			while(index!=-1)
			{
				Console.Clear();
				Console.WriteLine("Wybierz plec\n1. Mezczyzna\n2. Kobieta");
				try
				{
					Console.WriteLine(Generate(ReadInt()));
				}catch(Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
				Console.WriteLine("Wygenerowac ponownie?\n1. Tak\n2. Nie (Wyjdz z programu)");
				index = ReadInt();
				if (index == 2)
				{
					index = -1;
				}
			}
		}
		private static string Generate(int index)
		{
			string result = "";
			switch (index)
			{
				case 1:
					{
						result = $"{credentials[new Random().Next(0, credentials.Count + 1)]} {maleNames[new Random().Next(0, maleNames.Count + 1)]} {surnames[new Random().Next(0, surnames.Count + 1)]}";
						break;
					}
				case 2:
					{
						result = $"{credentials[new Random().Next(0, credentials.Count + 1)]} {femaleNames[new Random().Next(0, femaleNames.Count + 1)]} {surnames[new Random().Next(0, surnames.Count + 1)]}";
						break;
					}
			}
			return result;
		}
		private static void Load()
		{
			femaleNames = File.ReadAllLines("FemaleNames.txt").ToList();
			maleNames = File.ReadAllLines("MaleNames.txt").ToList();
			surnames = File.ReadAllLines("Surnames.txt").ToList();
			credentials = File.ReadAllLines("Credentials.txt").ToList();

		}
		private static int ReadInt()
		{
			return int.Parse(Console.ReadLine());
		}
	}
}
