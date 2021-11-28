using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgos
{
    public static class CountingSort
    {
        public static int[] CountSort(int[] numbers, int maxNumberValue)
        {
            int[] helper = new int[maxNumberValue + 2];

            //bucket each value in numbers as keys
            for(int i = 0; i < numbers.Length; i++)
            {
                helper[numbers[i]]++;
            }

            for(int j = 1; j < helper.Length; j++)
            {
                helper[j] = helper[j] + helper[j - 1];
            }
            //shift
            for(int k = helper.Length -1 ; k > 0; k--)
            {
                helper[k] = helper[k - 1];
            }

            int[] sorted = new int[numbers.Length];
            
            for(int k = 0; k < numbers.Length; k++)
            {
                int num = numbers[k];
                int numIndex = helper[num]; //we didnt shift the indexes by 1 cell, so we are just looking back by 1, this would fail if there was a zero.

                //set the number in the sorted array in its place
                sorted[numIndex] = num;

                //update the index to the next one
                helper[num]++;
            }

            return sorted;
        }
    }
}
