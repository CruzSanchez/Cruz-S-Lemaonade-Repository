using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class UserInteraction
    {
        private delegate bool TryParse<T>(string text, out T value);

        private static T getUserInput<T>(string question, string retryPrompt, TryParse<T> func)
        {
            Console.WriteLine(question);

            T response;
            while(!func(Console.ReadLine(), out response))
            {
                Console.WriteLine(retryPrompt + question);
            }

            return response;
        }

		public static int GetUserInputInt(string question)
		{
            return getUserInput<int>(question, "That wasn't the right input. ", int.TryParse);			
		}

		public static decimal GetUserInputDecimal(string question)
		{
            // return getUserInput<decimal>(question, "That wasn't the right input. ", decimal.TryParse);

			Console.WriteLine(question);

			decimal Response;
			while (!decimal.TryParse(Console.ReadLine(), out Response))
			{
				Console.WriteLine("That wasn't the right input." + question);
			}

			return Response;
		}
	}
}
