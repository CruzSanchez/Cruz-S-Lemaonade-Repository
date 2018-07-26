using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class UserInteraction
    {

		public static int GetUserInputInt(string question)
		{
			Console.WriteLine(question);

			int Response;
			bool IsParsed = int.TryParse(Console.ReadLine(), out Response);

			while(IsParsed == false)
			{
				Console.WriteLine("That wasn't the right input." + question);
				IsParsed = int.TryParse(Console.ReadLine(), out Response);
			}
			return Response;
			
		}

		public static decimal GetUserInputDecimal(string question)
		{
			Console.WriteLine(question);

			decimal Response;
			bool IsParsed = decimal.TryParse(Console.ReadLine(), out Response);

			while (IsParsed == false)
			{
				Console.WriteLine("That wasn't the right input." + question);
				IsParsed = decimal.TryParse(Console.ReadLine(), out Response);
			}
			return Response;

		}
	}
}
