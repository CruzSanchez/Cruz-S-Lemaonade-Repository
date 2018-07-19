using System;

namespace LemonadeStand
{
    class Program
    {
		static void Main(string[] args)
		{
			LemonadeStand newUserStand = new LemonadeStand();
			

			Console.WriteLine("Hello! Seems you would like to start a lemonade stand. What would you like to name it?");
			newUserStand.standName = Console.ReadLine();
			
			Console.WriteLine("Ahhhh yes! " + newUserStand.standName + " thats a great name!");
			Console.WriteLine();


			Console.WriteLine("Well we will need some basic information, like how many cups of lemonade you plan to sell?");

			newUserStand.numOfCups = Int32.Parse(Console.ReadLine()); // Variable for cups to sell converted to an int.
			if (newUserStand.numOfCups < 25)
			{
				Console.WriteLine("Well thats a pretty low number. Your loss I suppose.");
			}
			else
			{
				Console.WriteLine("Hmmm, very good!");
			}

			Console.WriteLine();
			Console.WriteLine("So how much will you sell them for?");

			newUserStand.customerPrice = decimal.Parse(Console.ReadLine()); // Variable for price to sell to customers converted to an decimal.	
			if(newUserStand.customerPrice > 2.5m)
			{
				Console.WriteLine("You might want to reconsider, thats highway robbery, but hey it's your bussiness.");
			}
			else
			{
				Console.WriteLine("Thats a pretty basic price. If thats the case... ");
			}
			Console.WriteLine();
			Console.WriteLine("How much does it cost you to make the lemonade??");

			newUserStand.sellerCost = decimal.Parse(Console.ReadLine()); // Variable for the users cost converted to decimal.
			if(newUserStand.sellerCost >= newUserStand.customerPrice)
			{
				Console.WriteLine("I can already tell this won't end well....");
			}

			Console.WriteLine();
			decimal totalRevenue = newUserStand.numOfCups * newUserStand.customerPrice - newUserStand.numOfCups * newUserStand.sellerCost;
			
			Console.WriteLine("Well if I calculate that all together, this is how much cash you'll be making! " + totalRevenue);
			Console.WriteLine();
			if (totalRevenue > 0)
			{
				Console.WriteLine("Hey, thats great you'er in the green. Keep at it and you'll be in the big leagues like yours truly. ;)");
	
			}

			if (totalRevenue < 0)
			{
				Console.WriteLine(".... Wait you won't be making any money at all... O__O ... YOU'RE LOSING MONEY!!!!! Close up shop");
				Console.WriteLine("and try again after your chapter 11.");
			}

			if (totalRevenue == 0)
			{
				Console.WriteLine("Yikes... barely broke even on that business model. Maybe go back to the whiteboard and rethink things.");
				Console.WriteLine("Perhaps increase your price? You could also find a less expensive vendor for supplies.");
			}
			
			Console.ReadLine();
        }

    }
}
