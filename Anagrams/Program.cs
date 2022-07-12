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

            List<string> res = GetUniqueAnagramListUsingHashSet(input);
           
            res.Sort();

            List<string> res1 = GetUniqueAnagramListUsingDictionary(input);

            res1.Sort();

            Console.WriteLine("Hello World!");

        }


        // Using HashSet and a Separate List to store the Result
        private static List<string> GetUniqueAnagramListUsingHashSet(List<string> input)
        {
            List<string> resultList = new List<string>();
            HashSet<string> set = new HashSet<string>();
            
            foreach(string str in input)
            {
                //string temp = str;
                char[] temp = str.ToCharArray();
                Array.Sort(temp);
                int x = 1000;
                string s = new string(temp); // DO NOT USE : temp.ToString(). Because it will give the value as "System.Char" and assigns to s 
                if (!set.Contains(s))
                {
                    set.Add(s);
                    resultList.Add(str);
                }
               
                Console.WriteLine(temp);
            }
            
            return resultList;
          
        }

        // Using Dictionary . Store Key as unique string which is sorted chars and Value as Original string.
        // Return the Dictionary.Values as the resulting List.
        private static List<string> GetUniqueAnagramListUsingDictionary(List<string> input)
        {
            Dictionary<string, string> r = new Dictionary<string, string>();
            
            foreach (string str in input)
            {
                //string temp = str;
                char[] temp = str.ToCharArray();
                Array.Sort(temp);
             
                string s = new string(temp); // DO NOT USE : temp.ToString(). Because it will give the value as "System.Char" and assigns to s 
                if (!r.ContainsKey(s))
                {
                    r.Add(s, str);    
                }

               
            }

            return new List<string>(r.Values);

        }
    }
}
