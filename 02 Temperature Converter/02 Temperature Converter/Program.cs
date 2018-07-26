using System;

namespace _02_Temperature_Converter
{
    class Program
    {

        static void Main(string[] args)
        {
			while (true)
			{
				string x, y = "";
				
				float temperature = 0;
				Console.Clear();
				Console.WriteLine("Zamiana temperatury x na y\nWprowadz pierwsza litere nazwy skali" +
					"\n(Dla zamiany Celcjuszy na Kelwiny: x=C,y=K)" +
					"\nWprowadz x");
				x = Console.ReadLine();
				Console.WriteLine("Wprowadz y");
				y = Console.ReadLine();
				Console.WriteLine("Wprowadz temperature");
				temperature = float.Parse(Console.ReadLine());
				if (x == y)
				{
					Console.WriteLine(temperature);
				}else
				{
					Console.WriteLine("Po konwersji temperatura wynosi: "+ Convert(x, y, temperature));
				}
				Console.WriteLine("Wcisnij dowolny klawisz");
				Console.ReadKey();
			}
        }
		static float Convert(string x,string y, float temperature)
		{
			
			switch (char.Parse(x))
			{
				case 'K':
					{
						switch (char.Parse(y))
						{
							case 'C':
								{
									return temperature - 273.15f;
									
								}
							case 'F':
								{
									return ((temperature * 9 )/ 5 - 459.67f);
									
								}
							case 'R':
								{
									return ((temperature * 9) / 5);
								}
						}

						break;
					}
				case 'C':
					{
						switch (char.Parse(y))
						{
							case 'K':
								{
									return temperature + 273.15f;
									
								}
							case 'F':
								{
									return (((temperature * 9) / 5) + 32);
								
								}
							case 'R':
								{
									return (((temperature + 273.15f) * 9) / 5);
								}
						}
						break;
					}
				case 'F':
					{
						switch (char.Parse(y))
						{
							case 'C':
								{
									return ((temperature - 32) * 5 )/ 9;
								
								}
							case 'K':
								{
									return (((temperature + 459.67f) * 5)/9);
								}
							case 'R':
								{
									return temperature + 459.67f;
								}
						}
						break;
					}
				case 'R':
					{
						switch (char.Parse(y))
						{
							case 'C':
								{
									return ((temperature - 491.67f) * 5) / 9;

								}
							case 'K':
								{
									return ((temperature * 5) / 9);
								}
							case 'F':
								{
									return temperature - 459.67f;
								}
						}
						break;
					}
			}
			throw new Exception("Wprowadzono bledne wartosci");
		}
    }
	
}
