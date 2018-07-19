using System;

namespace LemonadeStand
{
    class Program
    {
		static void Main(string[] args)
		{
			LemonadeStand newUserStand = new LemonadeStand();
			LemonadeStand nextStand = new LemonadeStand();

			Console.WriteLine("Hello! Seems you would like to start a lemonade stand. What would you like to name it?");
			newUserStand.standName = Console.ReadLine();
			
			Console.WriteLine("Ahhhh yes! " + newUserStand.standName + " thats a great name!");
			Console.WriteLine();
			Console.WriteLine("Lets go ahead and open a second one, whats it's name?");
			Console.WriteLine();

			nextStand.standName = Console.ReadLine();
			Console.WriteLine(nextStand.standName + " Excellent! I think I like the first one better honestly." );
			Console.WriteLine();
			Console.WriteLine("Well we will need some basic information, like how many cups of lemonade you plan to sell in your first stand?");

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
			Console.WriteLine("How many will the second stand sell?");
			nextStand.numOfCups = Int32.Parse(Console.ReadLine()); // Variable for cups to sell converted to an int.
			if (nextStand.numOfCups < 25)
			{
				Console.WriteLine("Your not exactly grasping this whole entrepreneur thing are you?");
			}
			else
			{
				Console.WriteLine("Awesome!");
			}

			Console.WriteLine();
			Console.WriteLine("So how much will you sell the lemonade for?");

			
			newUserStand.customerPrice = decimal.Parse(Console.ReadLine()); // Variable for price to sell to customers converted to an decimal.
			nextStand.customerPrice = newUserStand.customerPrice;
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
			nextStand.sellerCost = newUserStand.sellerCost;
			if(newUserStand.sellerCost >= newUserStand.customerPrice)
			{
				Console.WriteLine("I can already tell this won't end well....");
			}

			Console.WriteLine();
			decimal totalRevenue = newUserStand.numOfCups * newUserStand.customerPrice - newUserStand.numOfCups * newUserStand.sellerCost;
			
			Console.WriteLine("Well if I calculate that all together, this is how much cash you'll be making in the first stand! " + totalRevenue);
			Console.WriteLine();
			if (totalRevenue > 0)
			{
				Console.WriteLine("Hey, thats great you'er in the green. Keep at it and you'll be in the big leagues like yours truly. ;)");


			}
			else if (totalRevenue < 0)
			{
				Console.WriteLine(".... Wait you won't be making any money at all... O__O ... YOU'RE LOSING MONEY!!!!! Close up shop");
				Console.WriteLine("and try again after your chapter 11.");
			}
			else if (totalRevenue == 0)
			{
				Console.WriteLine("Yikes... barely broke even on that business model. Maybe go back to the whiteboard and rethink things.");
				Console.WriteLine("Perhaps increase your price? You could also find a less expensive vendor for supplies.");
			}

			Console.WriteLine();
			decimal totalRevenue2 = nextStand.numOfCups * nextStand.customerPrice - nextStand.numOfCups * nextStand.sellerCost;
			Console.WriteLine("Now for your second stand... Ah yes here is the figure:" + totalRevenue2);
			Console.WriteLine();
			if(totalRevenue2 > 0)
			{
				Console.WriteLine("Nice! We are making some $$$ now");
			}
			else if (totalRevenue2 == 0)
			{
				Console.WriteLine(".... well lets try harder next time.");
			}
			else if(totalRevenue2 < 0)
			{
				Console.WriteLine("You'll be out of money in less than a month, Change something or close up.");
			}

			Console.ReadLine();
        }

    }
}
