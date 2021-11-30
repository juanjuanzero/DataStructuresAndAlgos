using LinkedListsStacksQueues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestDataStructuresAndAlgos.LinkedListStacksQueues
{
    public class LinkedLists
    {
        [Fact]
        public void Test1()
        {
            var linkedList = new DoublyLinkedLists<int>();
            for (int i = 0; i < 6; i++)
            {
                linkedList.AddHead(i);
            }

            Assert.Equal(5, linkedList.Head.Value);
            Assert.Equal(0, linkedList.Tail.Value);
        }
        
        [Fact]
        public void Test2()
        {
            var linkedList = new DoublyLinkedLists<int>();
            for (int i = 0; i < 6; i++)
            {
                linkedList.AddTail(i);
            }

            Assert.Equal(5, linkedList.Tail.Value);
            Assert.Equal(0, linkedList.Head.Value);
        }

        [Fact]
        public void Test3()
        {
            var linkedList = new DoublyLinkedLists<int>();
            for (int i = 0; i < 6; i++)
            {
                linkedList.AddTail(i);
            }
            var b = linkedList.Contains(4);
            Assert.True(b);
        }

        [Fact]
        public void Test4()
        {
            var linkedList = new DoublyLinkedLists<int>();
            for (int i = 0; i < 6; i++)
            {
                linkedList.AddTail(i);
            }
            //
            var b = linkedList.Remove(4);
            Assert.True(b);

            //remove the tail
            var c = linkedList.Remove(5);
            Assert.Equal(3, linkedList.Tail.Value);
        }
    }
}
