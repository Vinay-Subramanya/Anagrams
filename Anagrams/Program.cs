using System;
using System.Collections.Generic;

namespace Anagrams
{
    // Program to return the Unique Anagram of strings by removing the strings that are anagrams of previous string.
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = new List<string>() { "abc", "xyz", "acb", "abcd", "zxy" };
            //Here, acb is the anagram of "abc". Hence remove acb and Keep "abc".
            //"abcd" is not an anagram of previous string. So keep it.
            //"zxy" is the Anagram of "xyz". So remove it and Keep only "xyz".
            //Output should be {"abc", "abcd", "xyz"}

            List<string> res = AnagramHelper.GetUniqueAnagramListUsingHashSet(input);
           
            res.Sort();

            List<string> res1 = AnagramHelper.GetUniqueAnagramListUsingDictionary(input);

            res1.Sort();

            Console.WriteLine("Hello World!");

        }
    }
}
