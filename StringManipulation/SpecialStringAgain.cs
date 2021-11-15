using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    public static class SpecialStringAgain
    {
        /// <summary>
        /// Counts the number of special substrings where all chars are the same or all chars except the middle is the same
        /// </summary>
        /// <param name="n">length of string</param>
        /// <param name="str">string</param>
        /// <returns></returns>
        public static long substrCount1(int n, string str)
        {
            var cnt = 0;
            for (int substrLenghtTarget = 1; substrLenghtTarget <= n; substrLenghtTarget++)
            {
                //looping through each char in the str
                //create a dictionary to see if it satisfies the conditions

                if (substrLenghtTarget == 1)
                {
                    cnt = str.Length;
                }
                else
                {
                    //get each of the substring
                    for (int i = 0; i <= n - substrLenghtTarget; i++)
                    {
                        //var sub = str.Substring(i, substrLenghtTarget);
                        var s = string.Empty;
                        for (int subStr = 0; subStr < substrLenghtTarget; subStr++)
                        {
                            s += str[i + subStr];
                        }

                        if (isValidSubString(s))
                        {
                            //increment
                            cnt++;
                        }
                    }
                }
            }

            return cnt;
        }

        public static bool isValidSubString(string sStr)
        {
            Dictionary<char, int> countDict = new();

            for (int j = 0; j <= sStr.Length - 1; j++)
            {
                if (countDict.ContainsKey(sStr[j]))
                {
                    countDict[sStr[j]] += 1;
                }
                else
                {
                    countDict[sStr[j]] = 1;
                }
            }

            if (sStr.Length % 2 == 0)
            {
                //its even
                if (countDict.Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                //its odd

                if (countDict.Count == 2)
                {
                    //there should only be one item and it has a count of 1
                    //the item with a count of 1 will be at the midpoint.
                    var midpoint = (sStr.Length / 2);
                    var midValue = sStr[midpoint];
                    if (countDict[midValue] == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (countDict.Count == 1)
                {
                    //its all the same letter
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        //someone else's solution
        public static long substrCountHrSol(int n, string str)
        {
            long returnVal = str.Length;

            //loop through the entire length of the str
            for(int i = 0; i < str.Length; i++)
            {
                var startChar = str[i]; //starting char
                int diffCharIdx = -1; //??

                //have a second pointer to look at the next set of letters
                for (int j = i + 1; j < str.Length; j++)
                {
                    var currChar = str[j]; //the next immediate set
                    if(startChar == currChar)
                    {
                        //the starting char is equal to the current char
                        //check if the different char is -1 or 
                        if((diffCharIdx == -1) || (j - diffCharIdx) == (diffCharIdx - 1))
                        {
                            returnVal++;
                        }
                    }
                    else
                    {
                        if(diffCharIdx == -1)
                        {
                            diffCharIdx = j;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }   

            return returnVal;
        }

        public static long substrCount2(int n, string str)
        {
            var cnt = 0;
            for (int substrLenghtTarget = 1; substrLenghtTarget <= n; substrLenghtTarget++)
            {
                //looping through each char in the str
                //create a dictionary to see if it satisfies the conditions

                if (substrLenghtTarget == 1)
                {
                    cnt = str.Length;
                }
                else
                {
                    //get each of the substring
                    for (int i = 0; i <= n - substrLenghtTarget; i++)
                    {
                        var s = string.Empty;
                        var midpoint = (substrLenghtTarget / 2);
                        var mid = new char();
                        Dictionary<char, int> countDict = new Dictionary<char, int>();
                        for (int subStr = 0; subStr < substrLenghtTarget; subStr++)
                        {
                            if (countDict.ContainsKey(str[i + subStr]))
                            {
                                countDict[str[i + subStr]] += 1;
                            }
                            else
                            {
                                countDict[str[i + subStr]] = 1;
                            }

                            if(subStr == midpoint)
                            {
                                mid = str[i + subStr];
                            }
                        }

                        if (substrLenghtTarget % 2 == 0)
                        {
                            //its even
                            if (countDict.Count == 1)
                            {
                                cnt++;
                            }
                        }
                        else
                        {
                            //its odd

                            if (countDict.Count == 2)
                            {
                                //there should only be one item and it has a count of 1
                                //the item with a count of 1 will be at the midpoint.
                                if (countDict[mid] == 1)
                                {
                                    cnt++;
                                }
                            }
                            else if (countDict.Count == 1)
                            {
                                //its all the same letter
                                cnt++;
                            }
                        }
                    }
                }
            }

            return cnt;
        }

        public static long substrCount(int n, string str)
        {
            long cnt = str.Length;
            for (int i = 0; i < str.Length; i++)
            {
                var startingChar = str[i];
                string charStr = str[i].ToString();
                //get the next letter
                for (int j = i + 1; j < str.Length; j++)
                {
                    var currentChar = str[j];
                  
                    //case 1: the characters are repeating
                    if(startingChar == currentChar)
                    {
                        charStr += currentChar;
                        cnt++;
                    }
                    else
                    {
                        //case 2: the characters are repeating but there is on in the middle
                        //the only way for it to count is if currentChar + charStr
                        bool isValid = false;
                        if(str.Length >= j + 1 + charStr.Length)
                        {
                            for (int k = j + 1; k < j + 1 + charStr.Length; k++)
                            {
                                //if it equals the starting char, then it is good
                                if(str[k] == startingChar)
                                {
                                    isValid = true;
                                    continue;
                                }
                                else
                                {
                                    isValid = false;
                                    break;
                                }
                            }
                        }

                        if (isValid)
                        {
                            cnt++;
                        }
                        break;

                    }
                }
            }
            return cnt;
        }
    }
}
