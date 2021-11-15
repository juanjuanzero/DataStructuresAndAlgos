using System;
using System.Collections.Generic;
using System.Linq;

namespace StringManipulation
{
    public static class SherlockAndValidStringSolution
    {
        public static string isValid(string s)
        {
            Dictionary<char, int> charDict = new Dictionary<char, int>();
            for (var i = 0; i < s.Length; i++)
            {
                if (charDict.ContainsKey(s[i]))
                {
                    charDict[s[i]] += 1;
                }
                else
                {
                    charDict[s[i]] = 1;
                }
            }

            Dictionary<int, int> countDict = new Dictionary<int, int>();
            //create another dicitonary where the counts are keys
            foreach (var k in charDict)
            {
                if (countDict.ContainsKey(k.Value))
                {
                    countDict[k.Value] += 1;
                }
                else
                {
                    countDict[k.Value] = 1;

                }
            }

            if (countDict.Count > 1)
            {
                if (countDict.Count == 2)
                {
                    var first = countDict.First();
                    var last = countDict.Last();
                    int minor = 0;
                    int minorKey = 0;

                    if(first.Value > last.Value)
                    {
                        minor = last.Value;
                        minorKey = last.Key;
                    }
                    else
                    {
                        minor = first.Value;
                        minorKey = first.Key;
                    }

                    //check to see if the difference between the first and second are by 1 or if theres only 1 item and the smaller value is 1
                    bool isOffByOne = (Math.Abs(first.Key - last.Key) == 1 || minorKey == 1)  && minor == 1;
                    if (!isOffByOne)
                    {
                        return "NO";
                    }
                }
                else
                {
                    //you'd need to delete more characters
                    return "NO";
                }
            }



            return "YES";

        }
    }
}
