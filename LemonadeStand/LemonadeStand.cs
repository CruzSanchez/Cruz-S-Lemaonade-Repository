using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class LemonadeStand
    {
		public string standName { get; set; }
		public decimal customerPrice { get; set; }
		public decimal sellerCost { get; set; }
		public int numSold { get; set; }
		


		
		public decimal getTotalRevenue()
		{
			return numSold * customerPrice;
		}
		
		public decimal getTotalExpense()
		{
			return numSold * sellerCost;
		}

		public decimal getTotalProfit()
		{
			return getTotalRevenue() - getTotalExpense();
		}

		public static void makeLemonStands()
		{
			Console.WriteLine("Lets open some lemonade stands, how many would you like to open?");
			int numofstands = int.Parse(Console.ReadLine());

			LemonadeHQ LemonCorp = new LemonadeHQ();

			for (int i = 0; i < numofstands; i++)
			{
				LemonadeStand newstand = new LemonadeStand();

				Console.WriteLine("What is the name of location " + (i + 1) + "?");
				newstand.standName = Console.ReadLine();

				Console.WriteLine("How many cups will this location sell?");
				newstand.numSold = int.Parse(Console.ReadLine());

				Console.WriteLine("What will your price to sell the lemonade be?");
				newstand.customerPrice = decimal.Parse(Console.ReadLine());


				Console.WriteLine("How much does it cost you to make the lemonade");
				newstand.sellerCost = decimal.Parse(Console.ReadLine());

				Console.WriteLine("This stands total revenue will be: " + newstand.getTotalRevenue());
				Console.WriteLine("The stands total expenses are: " + newstand.getTotalExpense());
				Console.WriteLine("Your total profit of " + newstand.standName + " is " + newstand.getTotalProfit());

				LemonCorp.Locations.Add(newstand);
			}
			LemonCorp.LemonCashReport();
		}


	}

	
}
