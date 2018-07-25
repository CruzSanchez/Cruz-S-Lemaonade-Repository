using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class PopcicleStand : LemonadeStand
    {
		public static void makePopStands()
		{
			Console.WriteLine("You look like you want more money. Lets open some popcicle stands. How many will we have?");
			int numofstands = int.Parse(Console.ReadLine());

			LemonadeHQ LemonCorp = new LemonadeHQ();

			for (int i = 0; i < numofstands; i++)
			{
				PopcicleStand newstand = new PopcicleStand();

				Console.WriteLine("What is the name of popcicle location " + (i + 1) + "?");
				newstand.standName = Console.ReadLine();

				Console.WriteLine("How many pops will this location sell?");
				newstand.numSold = int.Parse(Console.ReadLine());

				Console.WriteLine("What will your price to sell the pops be?");
				newstand.customerPrice = decimal.Parse(Console.ReadLine());


				Console.WriteLine("How much does it cost you to supply the popcicles?");
				newstand.sellerCost = decimal.Parse(Console.ReadLine());

				Console.WriteLine("This pop stand total revenue will be: " + newstand.getTotalRevenue());
				Console.WriteLine("The stand total expenses are: " + newstand.getTotalExpense());
				Console.WriteLine("Your total profit of " + newstand.standName + " is " + newstand.getTotalProfit());

				LemonCorp.Locations.Add(newstand);
			}

			LemonCorp.PopCashReport();
			LemonCorp.FinishParagraph();

		}

	}
}
