using System;

namespace _06_RockPaperScissorsLizardSpock
{
	/*
	                  Scissors cuts Paper 
                    Paper covers Rock 
                    Rock crushes Lizard 
                    Lizard poisons Spock 
                    Spock smashes Scissors 
                    Scissors decapitates Lizard 
                    Lizard eats Paper 
                    Paper disproves Spock 
                    Spock vaporizes Rock 
                    (and as it always has) Rock crushes Scissors 

	  
	 
	 */
	 enum Pick { Rock,Paper,Scissors,Lizard,Spock}
	class Program
    {
		static void Main(string[] args)
		{
			Pick pick = new Pick();
			while (true)
			{
				Console.Clear();
				Console.WriteLine("Co wybierasz?\n1.Rock\n2.Paper\n3.Scissors\n4.Lizard\n5.Spock\n6.Wyjdz");
				int index = int.Parse(Console.ReadLine());
				if (index == 6) return;
				pick = (Pick)index - 1;
				var AIPick = RandomAIPick();
				if (VerifyWinner(pick,AIPick))
				{
					Console.WriteLine("Wygrales!");
				}else
				{
					Console.WriteLine("Przegrales!");
				}
			}
		}
		static Pick RandomAIPick()
		{
			return (Pick)new Random().Next(0,6);
		}
		static bool VerifyWinner(Pick playerPick, Pick AIPick)
		{
			if(playerPick == Pick.Scissors && AIPick == Pick.Paper)
			{
				return true;
			}
			if (playerPick == Pick.Paper && AIPick == Pick.Rock)
			{
				return true;
			}
			if (playerPick == Pick.Rock && AIPick == Pick.Lizard)
			{
				return true;
			}
			if (playerPick == Pick.Lizard && AIPick == Pick.Spock)
			{
				return true;
			}
			if (playerPick == Pick.Scissors && AIPick == Pick.Lizard)
			{
				return true;
			}
			if (playerPick == Pick.Lizard && AIPick == Pick.Paper)
			{
				return true;
			}
			if (playerPick == Pick.Paper && AIPick == Pick.Spock)
			{
				return true;
			}
			if (playerPick == Pick.Spock && AIPick == Pick.Rock)
			{
				return true;
			}
			if (playerPick == Pick.Rock && AIPick == Pick.Scissors)
			{
				return true;
			}
			return false;
		}
    }
}
