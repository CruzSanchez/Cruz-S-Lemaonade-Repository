using System;
using System.Collections.Generic;

namespace LemonadeStand
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Lets open some lemonade stands, how many would you like to open?");
			int numofstands = int.Parse(Console.ReadLine());

			List<LemonadeStand> stands = new List<LemonadeStand>();

			for (int i = 0; i < numofstands; i++)
			{
				LemonadeStand newstand = new LemonadeStand();

				Console.WriteLine("What is the name of location " + (i + 1) + "?");
				newstand.standName = Console.ReadLine();

				Console.WriteLine("How many cups will this location sell?");
				newstand.numOfCups = int.Parse(Console.ReadLine());

				Console.WriteLine("What will your price to sell the lemonade be?");
				newstand.customerPrice = decimal.Parse(Console.ReadLine());

				Console.WriteLine("How much does it cost you to make the lemonade");
				newstand.sellerCost = decimal.Parse(Console.ReadLine());

				Console.WriteLine("This stands total revenue will be: " + newstand.getTotalRevenue());
				Console.WriteLine("The stands total expenses are: " + newstand.getTotalExpense());
				Console.WriteLine("Your total profit of " + newstand.standName + " is " + newstand.getTotalProfit());

				stands.Add(newstand);
			}

			Console.ReadLine();

		}
	}
}



