using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class Stands
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
	}

}
