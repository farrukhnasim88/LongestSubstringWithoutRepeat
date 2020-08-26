using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestSubstringWithoutRepeat
{
    // Find Longest Substring Without Repeating Characters
    class Program
    {
        static void Main(string[] args)
        {
            string s = "dvdf";
            int a;
            a = LengthOfLongestSubstring(s);
            Console.WriteLine(a);
           
        }
        static int LengthOfLongestSubstring(string s)
        {
            List<char> current = new List<char>();
            List<char> result = new List<char>();
            char[] charArr = s.ToCharArray();
            for(int i=0; i < charArr.Length; i++)
            {
                    if (!current.Contains(charArr[i]))
                    {
                        current.Add(charArr[i]);
                        if (i== charArr.Length-1 )
                        {
                             if (current.Count > result.Count)
                             {

                                 result = current;
                                 current = new List<char>();
                                 current.Add(charArr[i]);

                             }
                        }
                    }
                else
                {
                    if (current.Count > result.Count)
                    {

                        result = current;
                        current = new List<char>();
                        current.Add(charArr[i]);
                    }

                }
            }
            return result.Count;
        }
    }
}
