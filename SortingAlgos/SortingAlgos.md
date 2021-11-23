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