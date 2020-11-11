using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = CountTheDuplicates("ABBA");
            Console.WriteLine(res);
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


        public static int CountTheDuplicates(string str)
        {
            Dictionary<char, int> duplicateCounterDictionary = new Dictionary<char, int>();
            int counter = 1;
            var allLowerCaseString = str.ToLower();
            Console.WriteLine(allLowerCaseString);
            for (var i = 0; i < allLowerCaseString.Length; i++)
            {
                if (duplicateCounterDictionary.ContainsKey(allLowerCaseString[i]))
                {
                    duplicateCounterDictionary[allLowerCaseString[i]]++;
                }
                else
                {
                    duplicateCounterDictionary.Add(allLowerCaseString[i], counter);
                }
            }
            return duplicateCounterDictionary.Count(pair => pair.Value > 1);
        }
        #endregion


    }
}