using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Solution(4);
            Console.WriteLine(a);
        }
        #region TwoSum
        //public static int[] TwoSum(int[] numArray, int target)
        //{
        //    Dictionary<int, int> previousNumber = new Dictionary<int, int>();
        //    for (int i = 0; i < numArray.Length; i++)
        //    {
        //        var currentNumberInArray = numArray[i];
        //        var complement = target - currentNumberInArray;
        //        if (previousNumber.ContainsKey(complement))
        //        {
        //            return new[] { previousNumber[complement], i };
        //        }
        //        previousNumber.Add(numArray[i], i);

        //    }
        //    throw new Exception("Invalid input");
        //}

        #endregion
        #region CountTheDuplicates
        //    Count the number of Duplicates 
        //    Write a function that will return the count of distinct case-insensitive alphabetic characters
        //    and numeric digits that occur more than once in the input string. The input string can be 
        //    assumed to contain only alphabets(both uppercase and lowercase) and numeric digits.

        //  Example
        //"abcde" -> 0 # no characters repeats more than once
        //"aabbcde" -> 2 # 'a' and 'b'
        //"aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
        //"indivisibility" -> 1 # 'i' occurs six times
        //"Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
        //"aA11" -> 2 # 'a' and '1'
        //"ABBA" -> 2 # 'A' and 'B' each occur twice


        //public static int CountTheDuplicates(string str)
        //{
        //    Dictionary<char, int> duplicateCounterDictionary = new Dictionary<char, int>();
        //    int counter = 1;
        //    var allLowerCaseString = str.ToLower();
        //    Console.WriteLine(allLowerCaseString);
        //    for (var i = 0; i < allLowerCaseString.Length; i++)
        //    {
        //        if (duplicateCounterDictionary.ContainsKey(allLowerCaseString[i]))
        //        {
        //            duplicateCounterDictionary[allLowerCaseString[i]]++;
        //        }
        //        else
        //        {
        //            duplicateCounterDictionary.Add(allLowerCaseString[i], counter);
        //        }
        //    }
        //    return duplicateCounterDictionary.Count(pair => pair.Value > 1);
        //}
        #endregion
        #region findDiff


        //Your goal in this kata is to implement a difference function, which subtracts one list from another and returns the result.
        //It should remove all values from list a, which are present in list b.
        //Kata.ArrayDiff(new int[] {1, 2}, new int[] {1}) => new int[] { 2 } 
        //If a value is present in b, all of its occurrences must be removed from the other:
        //Kata.ArrayDiff(new int[] { 1, 2, 2, 2, 3 }, new int[] { 2 }) => new int[] { 1, 3 }

        public static int[] ArrayDiff(int[] a, int[] b)
        {
            var makeArrayAList = a.ToList();
            var makeArrayBList = b.ToList();
            List<int> newInts = new List<int>();
            if (makeArrayBList.Count < 1 || makeArrayAList.Count < 1) return makeArrayAList.ToArray();

            for (int i = 0; i < makeArrayAList.Count; i++)
            {
                for (int j = 0; j < makeArrayBList.Count; j++)
                {
                    if (makeArrayBList[j] != makeArrayAList[i])
                    {
                        newInts.Add(makeArrayAList[i]);
                    }
                }
            }

            return newInts.ToArray();
        }
        #endregion
        #region faceBookLikes
        //You probably know the "like" system from Facebook and other pages.People can "like" blog posts,
        //pictures or other items. We want to create the text that should be displayed next to such an item.
        //Implement a function likes :: [String] -> String, which must take in input array, 
        //containing the names of people who like an item.It must return the display text as shown in the examples:
        //Kata.Likes(new string[0]) => "no one likes this"
        //Kata.Likes(new string[] {"Peter"}) => "Peter likes this"
        //Kata.Likes(new string[] {"Jacob", "Alex"}) => "Jacob and Alex like this"
        //Kata.Likes(new string[] { "Max", "John", "Mark" }) => "Max, John and Mark like this"
        //Kata.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }) => "Alex, Jacob and 2 others like this"
        public static string Likes(string[] name)
        {

            switch (name.Length)
            {
                case 0:
                    return "no one likes this";
                case 1:
                    return $"{name[0]} likes this";
                case 2:
                    return $"{name[0]} and {name[1]} like this";
                case 3:
                    return $"{name[0]}, {name[1]} and {name[2]} like this"; ;
                default:
                    return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
            }
        }
        #endregion
        #region songDecoder 

        public static string SongDecoder(string input)
        {
            var inputArray = input.Split("WUB");
            inputArray = inputArray.Where((x) => !string.IsNullOrWhiteSpace(x)).ToArray();
            var finalStringJoin = string.Join(" ", inputArray);
            return finalStringJoin;
        }

        #endregion

        /**
         *Create a function taking a positive integer as its parameter and returning a string containing the Roman Numeral representation of that integer.
         * Modern Roman numerals are written by expressing each digit separately starting with the left most digit and skipping any digit with a value of zero.
         * In Roman numerals 1990 is rendered: 1000=M, 900=CM, 90=XC; resulting in MCMXC. 2008 is written as 2000=MM, 8=VIII; or MMVIII. 1666 uses each Roman symbol in descending order: MDCLXVI.
         * Example:
         * RomanConvert.Solution(1000) -- should return "M"
         * Help:
         * Symbol    Value
         * I          1
         * V          5
         * X          10
         * L          50
         * C          100
         * D          500
         * M          1,000
         * Remember that there can't be more than 3 identical symbols in a row.
         * More about roman numerals - http://en.wikipedia.org/wiki/Roman_numerals
         */



        public static string Solution(int number)
        {
            List<string> romanNumerals = new List<string>() { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            List<int> numerals = new List<int>() { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            var romanNumeral = string.Empty;
            while (number > 0)
            {
                var index = numerals.FindIndex(x => x <= number);

                romanNumeral += romanNumerals[index];
                number -= numerals[index];
            }
            return romanNumeral;
        }

    }
}