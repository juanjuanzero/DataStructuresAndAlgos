using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsStacksQueues
{
    public class SinglyLinkedListNode<T>
    {
        public SinglyLinkedListNode(T value)
        {
            this.Next = null;
            this.Value = value;
        }

        public SinglyLinkedListNode<T> Next { get; set; } //the next node in a linked list
        public T Value { get; set; } //the actual value 
    }
}
