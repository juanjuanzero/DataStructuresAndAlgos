using System;

namespace SortingAlgos
{
    public static class MergeSort
    {
        public static void mergeSortHR(int[] numbers)
        {
            int[] helper = new int[numbers.Length];
            mergeSortHR(numbers, helper, 0, numbers.Length - 1);
        }

        public static void mergeSortHR(int[] numbers, int[] helper, int low, int high)
        {
            if(low < high)
            {
                int middle = low + (high - low) / 2;
                mergeSortHR(numbers, helper, low, middle); //sort the left half
                mergeSortHR(numbers, helper, middle + 1, high); //soft the right half
                mergeHR(numbers, helper, low, middle, high); //merge the two
            }
        }

        public static void mergeHR(int[] numbers, int[] helper, int low, int middle, int high)
        {
            //Copy both halves into helper, or reset it
            for(int i = low; i <= high; i++)
            {
                helper[i] = numbers[i]; 
            }

            int helperLeft = low;
            int helperRight = middle + 1;
            int current = low;

            while(helperLeft <= middle && helperRight <= high)
            {
                if(helper[helperLeft] <= helper[helperRight])
                {
                    numbers[current] = helper[helperLeft]; //set the numbers array's at the current index to the value of the helper's left
                    helperLeft++; //increase the pointer to the leftside by one
                } else
                {
                    numbers[current] = helper[helperRight];
                    helperRight++;
                }
                current++;
            }

            //Copy the rest into the target array
            int remaining = middle - helperLeft;
            for(int i = 0; i <= remaining; i++)
            {
                numbers[current + i] = helper[helperLeft + 1];
            }
        }

        public static int[] mergeSortJuan(int[] numbers)
        {
            if(numbers.Length <= 2)
            {
                int[] helper = new int[numbers.Length];
                //if array is empty, return null
                //if array size is 2, compare two values
                if(numbers.Length == 2)
                {
                    if(numbers[0] <= numbers[1])
                    {
                        //its already sorted
                        return numbers;
                    }
                    else
                    {
                        //if not swap
                        helper[0] = numbers[1];
                        helper[1] = numbers[2];
                        return helper;
                    } 
                } else if(numbers.Length == 1)
                {
                    //if array size is 1 return 1
                    return numbers;
                } else
                {
                    return helper;
                }
            }
            else
            {
                //if array size is > 2, get the middle, copy into two arrays and compare
                int mid = -1;
                if(numbers.Length % 2 == 0)
                {
                    //even
                    mid = (numbers.Length / 2) - 1; //l/2 is the start of the right side.
                }
                else
                {
                    mid = numbers.Length / 2; //mid is the middle index
                }

                //create left side
                int[] leftSide = new int[mid + 1]; //mid plus one
                for(var l = 0; l <= mid; l++)
                {
                    leftSide[l] = numbers[l];
                }

                int[] rightSide = new int[numbers.Length - (mid + 1)]; //the remaining length
                for(var r = 0; r < rightSide.Length; r++)
                {
                    rightSide[r] = numbers[mid + r + 1]; //starting at mid + 1 to the end
                }

                //pass them into merge Sort
                int[] sortedLeft = mergeSortJuan(leftSide);
                int[] sortedRight = mergeSortJuan(rightSide);

                //merge the two 
                int[] merged = new int[sortedLeft.Length + sortedRight.Length];
                int leftPointer = 0;
                int rightPointer = 0;
                for(var i  = 0; i < merged.Length; i++)
                {
                    if(leftPointer < sortedLeft.Length && rightPointer < sortedRight.Length)
                    {
                        //both still have content
                        if(sortedLeft[leftPointer] <= sortedRight[rightPointer])
                        {
                            merged[i] = sortedLeft[leftPointer];
                            leftPointer++;
                        }
                        else
                        {
                            merged[i] = sortedRight[rightPointer];
                            rightPointer++;
                        }
                    }else if(leftPointer < sortedLeft.Length)
                    {
                        //left still has content
                        merged[i] = sortedLeft[leftPointer];
                        leftPointer++;
                    }else if(rightPointer < sortedRight.Length)
                    {
                        //right still has content
                        merged[i] = sortedRight[rightPointer];
                        rightPointer++;
                    }
                }

                return merged;
            }
            

        }
    }
}
