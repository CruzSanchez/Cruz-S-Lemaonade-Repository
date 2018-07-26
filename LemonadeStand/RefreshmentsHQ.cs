using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
	class RefreshmentsHQ
	{
		public string Name { get; set; }
		public List<Stands> LemonLocations { get; set; } = new List<Stands>();
		public List<Stands> PopcicleLocations { get; set; } = new List<Stands>();

		public void makeLemonStands()
		{

			int numofstands = UserInteraction.GetUserInputInt("Lets open some lemonade stands, how many would you like to open?");


			for (int i = 0; i < numofstands; i++)
			{
				LemonadeStand newstand = new LemonadeStand();

				Console.WriteLine($"What is the name of location {i + 1} ?");
				newstand.standName = Console.ReadLine();
				
				newstand.numSold = UserInteraction.GetUserInputInt("How many cups will this location sell?");

				newstand.customerPrice = UserInteraction.GetUserInputDecimal("What will your price to sell the lemonade be?");

				newstand.sellerCost = UserInteraction.GetUserInputDecimal("How much does it cost you to make the lemonade");

				Console.WriteLine($"This stands total revenue will be: { newstand.getTotalRevenue()}");
				Console.WriteLine("The stands total expenses are: " + newstand.getTotalExpense());
				Console.WriteLine("Your total profit of " + newstand.standName + " is " + newstand.getTotalProfit());

				LemonLocations.Add(newstand);
			}
		}

		public void makePopStands()
		{
			
			int numofstands = UserInteraction.GetUserInputInt("You look like you want more money. Lets open some popcicle stands. How many will we have?");
			
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

				PopcicleLocations.Add(newstand);
			}

		}

		public decimal LemonadeRevenue()
		{
			return sumRevenue(LemonLocations);
		}

		public decimal LemonadeExpenses()
		{
			return sumExpenses(LemonLocations);
		}

		public decimal LemonadeProfit()
		{
			return sumProfit(LemonLocations);
		}

		public decimal PopcicleRevenue()
		{
			return sumRevenue(PopcicleLocations);
		}

		public decimal PopcicleExpenses()
		{
			return sumExpenses(PopcicleLocations);
		}

		public decimal PopcicleProfit()
		{
			return sumProfit(PopcicleLocations);
		}

		private decimal sumRevenue(List<Stands> stands)
		{
			decimal sum = 0;
			foreach (Stands stand in stands)
			{
				sum += stand.getTotalRevenue();
			}
			return sum;
		}

		private decimal sumExpenses(List<Stands> stands)
		{
			decimal sum = 0;
			foreach(Stands stand in stands)
			{
				sum += stand.getTotalExpense();
			}
			return sum;
		}

		private decimal sumProfit(List<Stands> stands)
		{
			decimal sum = 0;
			foreach(Stands stand in stands)
			{
				sum += stand.getTotalProfit();
			}
			return sum;
		}

		public decimal AllRevenue()
		{
			return LemonadeRevenue() + PopcicleRevenue();
		}

		public decimal AllExpense()
		{
			return LemonadeExpenses() + PopcicleExpenses();
		}

		public decimal AllProfit()
		{
			return LemonadeProfit() + PopcicleProfit();
		}

		public void LemonCashReport()
		{
			Console.WriteLine("Total revenue of all stores is: " + LemonadeRevenue());
			Console.WriteLine("Total expense of all stores is: " + LemonadeExpenses());
			Console.WriteLine("Total profit of all stores is: " + LemonadeProfit());
			Console.WriteLine("Press enter to continue.");
			Console.ReadLine();
		}

		public void PopCashReport()
		{
			Console.WriteLine();
			Console.WriteLine("Total revenue of all pop stands is: " + PopcicleRevenue());
			Console.WriteLine("Total expense of all pop stands is: " + PopcicleExpenses());
			Console.WriteLine("Total profit of all pop stands is: " + PopcicleProfit());
			Console.WriteLine("Press enter to continue.");
			Console.ReadLine();
		}

		public void FinishParagraph()
		{
			Console.WriteLine();
			Console.WriteLine("Your corporation's total revenue for all the Lemonade stands and Popcicle stands are: " + AllRevenue());
			Console.WriteLine("The corporation total expenses are: " + AllExpense());
			Console.WriteLine("The corporation total profit is: " + AllProfit());
			Console.WriteLine();
			Console.WriteLine("Press enter please.");
			Console.ReadLine();
		}

	}
}
