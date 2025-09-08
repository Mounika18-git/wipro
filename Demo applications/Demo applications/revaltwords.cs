using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_applications
{
    internal class revaltwords
    {
        static void Main()
        {
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                // Reverse only alternate words (2nd, 4th, etc. → index 1, 3...)
                if (i % 2 == 1)
                {
                    char[] charArray = words[i].ToCharArray();
                    Array.Reverse(charArray);
                    words[i] = new string(charArray);
                }
            }

            string result = string.Join(" ", words);
            Console.WriteLine("Output: " + result);
        }
    }
}
