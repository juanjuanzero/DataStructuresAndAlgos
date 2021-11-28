using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using SortingAlgos;

namespace TestDataStructuresAndAlgos.Sorting
{
    public class CountSortTest
    {
        [Fact]
        public void Test1()
        {
            int[] v = new int[] { 2, 3, 1, 3, 4, 5 };
            var x = SortingAlgos.CountingSort.CountSort(v, 5);
            int[] a = new int[] { 1, 2, 3, 3, 4, 5 };
            Assert.Equal<int[]>( a, x);
        }

        [Fact]
        public void Test2()
        {
            int[] v = new int[] { 2, 3, 1, 3, 4, 5 , 9,9,9,9,9,9,9,9,9};
            var x = SortingAlgos.CountingSort.CountSort(v, 9);
            int[] a = new int[] { 1, 2, 3, 3, 4, 5, 9,9,9,9,9,9,9,9,9 };
            Assert.Equal<int[]>( a, x);
        }
    }
}
