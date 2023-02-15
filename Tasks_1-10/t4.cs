using System;
namespace olioohjelmointi
{
	public class T4
	{
        public static bool Palindrome(string word)
        {
            string reverse = string.Empty;
            foreach (char c in word)
            {
                reverse = c + reverse;
            }
            if (word.Equals(reverse, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
		static void Main()
		{
            Console.Write("Enter a string or a sentence to check palindrome : ");
            string word = Console.ReadLine();

            if(Palindrome(word) == true) 
            {

                Console.WriteLine($"{word} is Palindrome");
            }
            else
                Console.WriteLine($"{word} is not Palindrome");
            
        }
	}
}

