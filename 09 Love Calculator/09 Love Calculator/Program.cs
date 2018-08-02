using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09_Love_Calculator
{

	class Program
	{
		static string firstName;
		static string secondName;
		static string symbols = "'\\[].,/;{}:|<>?!@#$%^&*()-_=+` ";
		static List<LetterOccurance> letters = new List<LetterOccurance>();
		static void Main(string[] args)
		{
			GetNames();
			LoveAlgorithm();
			Console.ReadKey();
		}
		static void LoveAlgorithm()
		{
			string sentence = firstName + "loves" + secondName;
			GetLetters(sentence.ToLower());
			string number = LettersToNumber();
			number = ShortenNumber(number);
			while(true)
			{
				if (number.Length == 2) break;
				number = ShortenNumber(number);
			}
			Console.WriteLine($"{firstName} loves {secondName} in {number}%");
			


		}
		static string LettersToNumber()
		{
			string number = "";
			
				for (int i = 0; i < letters.Count/2; i++)
				{
					if (letters.Count % 2 == 0)
					{
						number += (letters[i].count + letters[letters.Count - 1 - i].count).ToString();
					}
					else
					{
						if (letters.Count / 2 == i)
						{
							number += letters[i].count.ToString();
						}
						else
						{
							number += (letters[i].count + letters[letters.Count - 1 - i].count).ToString();
						}
					}
				}
			
			
			return number;
		}
		static string ShortenNumber(string number)
		{

			string newNumber = "";
			int count = 0;
			if(number.Length%2==0)
			{
				count = number.Length / 2;
			}else
			{
				count = (number.Length / 2)+1;
			}
				for (int i = 0; i < count; i++)
				{
					int a = int.Parse(number[i].ToString());
					int b = int.Parse(number[number.Length - 1 - i].ToString());
					if (number.Length % 2 == 0)
					{
						newNumber += (a+b).ToString();
					}
					else
					{
						if (number.Length / 2 == i)
						{
							newNumber += a;
						}
						else
						{
							newNumber += (a+b).ToString();
						}
					}
				
		

				}
			return newNumber;
		}
		static void GetLetters(string sentence)
		{
			for(int i =0;i<sentence.Length;i++)
			{
				if(letters.Count>0)
				{
					LetterOccurance letterOccurance = new LetterOccurance(sentence[i], 1);
					if (IsInList(letterOccurance.letter))
					{
						continue;
					}
					else
					{
						for (int a = 0; a < sentence.Length; a++)
						{
							if (sentence[a] == letterOccurance.letter && a != i)
							{
								letterOccurance.count++;
							}
						}
						letters.Add(letterOccurance);
					}
				}
				else
				{
					LetterOccurance letterOccurance = new LetterOccurance(sentence[i], 1);
					for (int a = 0; a < sentence.Length; a++)
					{
						if(sentence[a] == letterOccurance.letter && a!=i)
						{
							letterOccurance.count++;
						}
					}
					letters.Add(letterOccurance);
				}
			}
		}
		static bool IsInList(char Letter)
		{
			List<LetterOccurance> list = letters.FindAll(let => let.letter == Letter).ToList();
			if (list.Count != 0)
			{
				return true;
			}
			else return false;
		}
		static void GetNames()
		{
			while (true)
			{
				Console.WriteLine("Write first name");
				string name = Console.ReadLine();
				if (String.IsNullOrEmpty(name))
				{
					Console.WriteLine("Wrong input!");
					continue;
				}
				if (isPotentialyCorrectName(name))
				{
					firstName = name;
					break;
				}
			}
			while (true)
			{
				Console.WriteLine("Write second name");
				string name = Console.ReadLine();
				if (String.IsNullOrEmpty(name))
				{
					Console.WriteLine("Wrong input!");
					continue;
				}
				if (isPotentialyCorrectName(name))
				{
					secondName = name;
					break;
				}


			}
		}
		static bool isPotentialyCorrectName(string name)
		{
			for (int i = 0; i < symbols.Length; i++)
			{
				if (name.IndexOf(symbols[i]) != -1)
				{
					Console.WriteLine("It's not a name!");
					return false;
				}
			}
			return true;
		}


	}
	public class LetterOccurance
	{
		public LetterOccurance(char Letter,int Count)
		{
			letter = Letter;
			count = Count;
		}
		
		public char letter;
		public int count;
	}
}
