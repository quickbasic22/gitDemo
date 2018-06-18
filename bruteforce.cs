using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace BruteForceCSharp
{
    public class Program
    {
        // Array with characters to use in Brute Force Algorithm.
        // You can remove or add more characters in this array.
        private static string fCharList = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
		private static string password;
		private static bool printEveryString = false;
		private static bool found = false;
        public static void Main(string[] args)
        {
			found = false;
			Console.Write("Enter password to brute force: ");
			password = Console.ReadLine();
			var time = DateTime.Now;
			//Note that anything above 4 characters will take a considerable amount of time.
			//You can cheat by only executing a specific length BF.
			for (int i=1; i<20; i++) //20 is the max word size
			{
				StartBruteForce(i);
			}
			var elapsed = DateTime.Now.Subtract(time).TotalMilliseconds;
			Console.WriteLine("Time elapsed {0}ms", elapsed);
        }
 

        public static void StartBruteForce(int length)
        {
            StringBuilder sb = new StringBuilder(length);
            char currentChar = fCharList[0];
 
            for (int i = 1; i <= length; i++)
            {
                sb.Append(currentChar);
            }
 
            ChangeCharacters(0, sb, length);
        }
 
        private static StringBuilder ChangeCharacters(int pos, StringBuilder sb, int length)
        {
            for (int i = 0; i <= fCharList.Length - 1; i++)
            {
                //sb.setCharAt(pos, fCharList[i]);
 
                sb.Replace(sb[pos], fCharList[i], pos, 1);
 
                if (pos == length - 1)
                {
					var word = sb.ToString();
					if (printEveryString)
					{
						// Write the Brute Force generated word.
						Console.WriteLine(word);
					}
					if (word == password)
					{
						Console.WriteLine("Found: {0}", word);
						found = true;
						break;
					}
                }
                else
                {
					if (!found)
					{
						ChangeCharacters(pos + 1, sb, length);
					}
                }
            }
 
            return sb;
        }
 
    }
}