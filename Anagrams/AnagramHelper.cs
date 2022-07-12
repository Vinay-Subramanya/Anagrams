using System;
using System.Collections.Generic;
using System.Text;

namespace Anagrams
{
    static class AnagramHelper
    {

        // Using HashSet and a Separate List to store the Result
        public static List<string> GetUniqueAnagramListUsingHashSet(List<string> input)
        {
            List<string> resultList = new List<string>();
            HashSet<string> set = new HashSet<string>();

            foreach (string str in input)
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
        public static List<string> GetUniqueAnagramListUsingDictionary(List<string> input)
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
