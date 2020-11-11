using System;
using System.Linq;

namespace RemoveVowel
{
    class Program
    {
        static void Main(string[] args)
        {
            string finalString = RemoveVowel("leetcodeisacommunityforcoders");
            Console.WriteLine(finalString);
        }

        public static string RemoveVowel(string s)
        {

            string[] notAllowedChars = new string[] {"a", "e", "i", "o", "u"};
            if (s.Length >= 1 && s.Length <= 1000)
            {
                foreach (var letter in notAllowedChars)
                {
                   s = s.Replace(letter, string.Empty);
                }
            }
            else
            {
                Console.WriteLine("non valid string");
            }
            return s;
        }
    }
}
