using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
	class LemonadeHQ
	{
		public string Name { get; set; }
		public List<LemonadeStand> Locations { get; set; } = new List<LemonadeStand>();


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
			foreach(LemonadeStand location in Locations)
			{
				grandExpense += location.getTotalExpense();
			}
			return grandExpense;
		}

		public decimal CorperationProfit()
		{
			decimal grandProfit = 0;
			foreach(LemonadeStand location in Locations)
			{
				grandProfit += location.getTotalProfit();
			}
			return grandProfit;
		}
	}
}
