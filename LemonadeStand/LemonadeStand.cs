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
		public int numOfCups { get; set; }
		


		
		public decimal getTotalRevenue()
		{
			return numOfCups * customerPrice;
		}
		
		public decimal getTotalExpense()
		{
			return numOfCups * sellerCost;
		}

		public decimal getTotalProfit()
		{
			return getTotalRevenue() - getTotalExpense();
		}


	}

	
}
