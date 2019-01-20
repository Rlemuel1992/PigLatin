using System;

namespace PigLatin
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Please write a word you want to translate to Pig Latin!\n" +
							  "For quality translation purposes, please write numbers out \n" +
							  "ex. 1 should be one, 3 should be three.");
			string piggy = Console.ReadLine();
			
			/* The line underneath is to convert the word to lower, but the extended
			 * challenge asks me to keep the casing of the words. 
			 piggy = piggy.ToLower();
			*/

			//if there's a mis-type.
			if (piggy.StartsWith(' ') || piggy == string.Empty || piggy.Contains('@') || piggy.)
			{
				Console.WriteLine("Please use words!\n\n");
				Main();
			}
			//If piggy starts with vowels
			else if (piggy.StartsWith('a') || piggy.StartsWith('e') ||
				piggy.StartsWith('i') || piggy.StartsWith('o') || piggy.StartsWith('u'))
			{
				Console.WriteLine(piggy + "way \n\n");
				Again();
			}
			// Checking if piggy is letters only.
			else if (!System.Text.RegularExpressions.Regex.IsMatch(piggy, "^[a-zA-Z ]"))
			{
				Console.WriteLine("No numbers!\n\n");
				Main();
			}
			else
			{
				IsAVowel(piggy);
			}
		}
			public static void IsAVowel(string piggy)
			{
			int x;
			piggy.ToCharArray();
			char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
			x = piggy.IndexOfAny(vowels);
			string z = piggy.Substring(0, x);
			string final = piggy.Substring(x, piggy.Length - x);
			Console.WriteLine(final + z + "ay");
			Again();
			}
		

		public static void Again()
		{
			Console.WriteLine("Would you like to translate another? 'y/n'");
			string again = Console.ReadLine();
			again.ToLower();
			if (again == "y")
			{
				Main();
			}
			else if (again == "n")
			{
				Console.WriteLine("Laterrrrr! Press any key to get out");
				Console.ReadKey();
				Environment.Exit(1);
			}
			else
			{
				Console.WriteLine("Sorry, didn't quite catch that");
				Again();
			}

		}
	}
}