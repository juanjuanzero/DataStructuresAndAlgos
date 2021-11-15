using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    public static class CommonChild
    {
        public static int commonChildBruteForce(string s1, string s2)
        {
            //find longest commonChild between two strings
            //a common child is a child of one string with the same letter and order of the other
            //both strings are of equal length
            //bruteForce is to loop through each letter in s1 and check if its in s2 and find substrings and report back everything
            var dict = new Dictionary<char, List<int>>();
            for (int i = 0; i < s1.Length; i++)
            {
                var indxList = new List<int>();
                //loop through and find indexs in the other string
                for (int j = 0; j < s2.Length; j++)
                {
                    var subSub = s2.Substring(j).IndexOf(s1[i]);
                    if (subSub != -1)
                    {
                        j = subSub + 1;
                        indxList.Add(subSub);
                    }
                }
                if (!dict.ContainsKey(s1[i]))
                {
                    dict.Add(s1[i], indxList);
                }
            }

            //loop through and find the largest chain of indexes
            List<int> cnts = new List<int>();
            for (var j = 0; j < s1.Length; j++)
            {
                if (dict[s1[j]].Count > 0)
                {
                    var cnt = 1;
                    var indexList = dict[s1[j]];
                    for (var d = 0; d < indexList.Count; d++)
                    {
                        var index = indexList[d];
                        //there is a match
                        //look for other letters that have an index greater than the current index.
                        var k = j + 1;
                        while (k < s1.Length)
                        {
                            var idx = dict[s1[k]].Where(x => x > index);
                            if(idx != null && idx.Count() > 0)
                            {
                                if (idx.Min() > 0)
                                {
                                    index = idx.Min();
                                    cnt++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            k++;
                            
                        }
                    }
                    cnts.Add(cnt);
                }
            }
            if(cnts.Count > 0)
            {
                return cnts.Max();
            }
            else
            {
                return 0;
            }
        }

        public static int commonChild(string s1, string s2)
    {
        int maxCount = 0;
        int sLength = s2.Length;
        //for every char in s1, loop in s2 to see if a chat matches the s1 char.
        Dictionary<int, int[]> dict = new Dictionary<int, int[]>(){ { 0, new int[sLength+ 1] } };
        for (int row = 1; row <= sLength; row++)
        {
            int[] currRow = new int[sLength + 1]; //initializes with 0
            int[] prevRow = dict[row - 1];
            for (int col = 1; col <= sLength; col++)
            {
                //check if it matches the index
                if(s1[row - 1] == s2[col - 1])
                {
                    //if there is a match then take the top left (row - 1, col - 1) and add 1
                    currRow[col] = prevRow[col - 1] + 1;
                    if(maxCount < currRow[col])
                    {
                        maxCount = currRow[col];
                    }
                }
                else
                {
                    //if there is no match then take the max of the upper (r -1, c) or left (r, c - 1)
                    if(prevRow[col] > currRow[col - 1]){
                        currRow[col] = prevRow[col];
                    }else{
                        currRow[col] = currRow[col - 1];
                    }
                    //currRow[col] = new int[3] { prevRow[col - 1], prevRow[col], currRow[col - 1] }.Max();
                    maxCount = currRow[col];
                }
            }
            dict.Add(row, currRow);
            //
        }
        return maxCount;
    }

    }
}
