using System;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {

			Console.WriteLine("Hello! Seems you would like to start a lemonade stand. What would you like to name it?");
			var lemonadeStandName = Console.ReadLine(); // Variable for stand name

			Console.WriteLine("Ahhhh yes! " + lemonadeStandName + " thats a great name!");
			Console.WriteLine();


			Console.WriteLine("Well we will need some basic information, like how many cups of lemonade you plan to sell?");
			int cupsOfLemonade = Int32.Parse(Console.ReadLine()); // Variable for cups to sell converted to an int.

			Console.WriteLine("Hmmm, very good! So, how much will they cost?");

			decimal buyerPrice = Decimal.Parse(Console.ReadLine()); // Variable for price to sell to customers converted to an decimal.	
			
			Console.WriteLine("Thats a pretty basic price. If thats the case... How much does it cost you to make per cup?");

			decimal userCost = Decimal.Parse(Console.ReadLine()); // Variable for the users cost.

			decimal totalRevenue = buyerPrice * cupsOfLemonade - userCost * cupsOfLemonade;
			Console.WriteLine("Well if I calculate that all together, this is how much cash you'll be making! " + totalRevenue);
			Console.WriteLine();
			if(totalRevenue > 0)
			{
				Console.WriteLine("Hey, thats great you'er in the green. Keep at it and you'll be in the big leagues like yours truly. ;)");
			}

			if(totalRevenue < 0)
			{
				Console.WriteLine(".... Wait you won't be making any money at all... O__O ... YOU'RE LOSING MONEY!!!!!");
			}

			if(totalRevenue == 0)
			{
				Console.WriteLine("Yikes... barely broke even on that business model. Maybe go back to the whiteboard and rethink things.");
				Console.WriteLine("Perhaps increase your price? You could also find a less expensive vendor for supplies.");
			}

			


			Console.ReadLine();





        }
    }
}
