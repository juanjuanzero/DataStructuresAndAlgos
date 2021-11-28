# Sorting Algorithms

## Merge Sort
The premise behind merge sort is the following:
 1. Split the array in half
 2. Sort each half (using mergesort, ofC!)
 3. Merge each half by taking the smaller item from each half first.

Merge sort is often done recursively where you are getting to smaller and smaller halves. Since it halves the steps each time, the time complexity of this algorithm is O(n l og n). The base for the log is 2 because of the halving. 

### Where do you see merge sort in reality?
This is classic divide an conquer. The problem is divided into subproblems until you reach the edge case of having an array of 2 or just 1. Then start building things back up.

### What was challenging for me?
The challenge for me was keeping track of when splitting the array, and inserting into the right and left side. A Classic off by Juan error.

### What is the space complexity?
The space complexity for this implementation would be O(3n) since each call creates two new arrays a left and right side, then another for a merged array to return up the call stack. 

### Where does merge sort shine?
Merge sort is faster than the Bubble Sort and Selection sort, Its also easier to explain since its a bit intuitive.

## Counting Sort
 Counting sort works best when there is a relatively small range of variability in the values in the array. There could be a large number of them, but it works best when dealing with a very defined range.

This also works best when sorting letters.

The idea behind Counting sort is to use the keys as a way to bucket similar values together, and then arrange the values using those ordered keys.

### What are the steps for Couting Sort?
1. Create helper array that is the size of the maximum value. This helper array will store the count instances of every item in the array.
2. Loop through the original array and store a count into the helper array using the values as keys.
3. Cummulate the counts and shift the counts by one key. The result will be a representation of the indexes of each value.
4. Create a sorted array to return as a result, this will be the same size as the original array.
5. Loop through the original array, for each item you encounter, get it's index using the helper array, then increase the index by 1 so that the next time you encounter the same number you can place it the same.

### What did i miss when working with Counting Sort?
I was thinking that if i shifted everything to the right then all i would need to do is the index + 1. But in reality, I didn't shift anything to the right but the answer was expecting that i did. So the real answer was index - 1.

The best solution is the simplest solution. I tried to combine the accummulation and the shift into one step and kept confusing myself. I went ahead and made them separate so its easier to read.