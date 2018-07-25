using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
	class LemonadeHQ
	{
		public string Name { get; set; }
		public List<LemonadeStand> Locations { get; set; } = new List<LemonadeStand>();
		public List<PopcicleStand> popcicleStandsLocations { get; set; } = new List<PopcicleStand>();

		public decimal CorperationRevenue()
		{
			decimal grandRevenue = 0;
			foreach (LemonadeStand location in Locations)
			{
				grandRevenue += location.getTotalRevenue();

			}

			return grandRevenue;
		}

		public decimal CorperationExpenses()
		{
			decimal grandExpense = 0;
			foreach (LemonadeStand location in Locations)
			{
				grandExpense += location.getTotalExpense();
			}
			return grandExpense;
		}

		public decimal CorperationProfit()
		{
			decimal grandProfit = 0;
			foreach (LemonadeStand location in Locations)
			{
				grandProfit += location.getTotalProfit();
			}
			return grandProfit;

		}

		public decimal popCorperationRevenue()
		{
			decimal grandRevenue = 0;
			foreach (PopcicleStand location in Locations)
			{
				grandRevenue += location.getTotalRevenue();

			}

			return grandRevenue;
		}

		public decimal popCorperationExpenses()
		{
			decimal grandExpense = 0;
			foreach (PopcicleStand location in Locations)
			{
				grandExpense += location.getTotalExpense();
			}
			return grandExpense;
		}

		public decimal popCorperationProfit()
		{
			decimal grandProfit = 0;
			foreach (PopcicleStand location in Locations)
			{
				grandProfit += location.getTotalProfit();
			}
			return grandProfit;

		}

		public decimal AllRevenue()
		{
			decimal Lemonrev = 0;
			decimal Poprev = 0;
			foreach (LemonadeStand location in Locations)
			{
				Lemonrev += location.getTotalRevenue();

			}
			foreach (PopcicleStand location in Locations)
			{
				Poprev += location.getTotalRevenue();

			}

			return Lemonrev + Poprev;

		}

		public decimal AllExpense()
		{
			decimal LemonExp = 0;
			decimal PopExp = 0;
			foreach (LemonadeStand location in Locations)
			{
				LemonExp += location.getTotalExpense();

			}
			foreach (PopcicleStand location in Locations)
			{
				PopExp += location.getTotalExpense();

			}
			return LemonExp + PopExp;
		}

		public decimal AllProfit()
		{
			decimal LemonPro = 0;
			decimal PopPro = 0;
			foreach (LemonadeStand location in Locations)
			{
				LemonPro += location.getTotalProfit();
			}
			foreach (PopcicleStand location in Locations)
			{
				PopPro += location.getTotalProfit();
			}
			return LemonPro + PopPro;
		}

		public void LemonCashReport()
		{
			Console.WriteLine("Total revenue of all stores is: " + CorperationRevenue());
			Console.WriteLine("Total expense of all stores is: " + CorperationExpenses());
			Console.WriteLine("Total profit of all stores is: " + CorperationProfit());
			Console.WriteLine("Press enter to continue.");
			Console.ReadLine();
		}

		public void PopCashReport()
		{
			Console.WriteLine();
			Console.WriteLine("Total revenue of all pop stands is: " + popCorperationRevenue());
			Console.WriteLine("Total expense of all pop stands is: " + popCorperationExpenses());
			Console.WriteLine("Total profit of all pop stands is: " + popCorperationProfit());
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
