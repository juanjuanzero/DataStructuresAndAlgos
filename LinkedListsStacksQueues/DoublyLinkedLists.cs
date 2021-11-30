using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListsStacksQueues
{
    public class DoublyLinkedLists<T> : ICollection<T>
    {
        public DoublyLinkedListNode<T> Head { get; private set; }
        public DoublyLinkedListNode<T> Tail { get; private set; }

        public int Count { get; set; }

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            AddHead(item);
        }

        //ADD HEAD, adds and makes the latest as the head.
        public void AddHead(T value)
        {
            //create a new node, the current head is the next node.
            DoublyLinkedListNode<T> toAdd = new DoublyLinkedListNode<T>(value);

            //set the pointer of the toAdd's Next node as the current Head.
            toAdd.Next = Head;

            //if its not the only node in the list, then set the pointer to the previous value.
            if(Head != null)
            {
                Head.Previous = toAdd;
            }
            //NOTE: at this point the Head hasn't been updated so all of the operations were the ones at the end.
            //update the current Head as the toAdd.
            Head = toAdd;

            //if there is only one item, then the tail is the head.
            if(Tail == null)
            {
                Tail = Head;
            }
            Count++;
        }

        public void AddTail(T value)
        {
            if(Tail == null)
            {
                AddHead(value);
            }
            else
            {
                DoublyLinkedListNode<T> toAdd = new DoublyLinkedListNode<T>(value);
                toAdd.Previous = Tail;
                
                //get the current tail, and update it to have a next value
                Tail.Next = toAdd;

                //update with the new Tail
                Tail = toAdd;

                Count++;
            }
        }

        public DoublyLinkedListNode<T> Find(T value)
        {
            if(Head == null)
            {
                return null;
            }

            DoublyLinkedListNode<T> current = Head;
            while(current != null)
            {
                if (current.Value.Equals(value))
                {
                    return current;
                }

                current = current.Next;
            }

            return null;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            var x = Find(item);
            if(x != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            DoublyLinkedListNode<T> current = Head;
            while(current != null)
            {
                yield return current.Value;
                current = current.Next; //reset to the next value
            }
        }

        public IEnumerator<T> GetReverseEnumerator()
        {
            DoublyLinkedListNode<T> current = Tail;
            while(current != null)
            {
                yield return current.Value;
                current = current.Previous; //reset to the next value
            }
        }

        public bool Remove(T item)
        {
            DoublyLinkedListNode<T> x = Find(item);
            if (x == null)
            {
                return false;
            }

            //check if its the head or the tail
            DoublyLinkedListNode<T> prev = x.Previous;
            DoublyLinkedListNode<T> next = x.Next;

            //if its the head
            if (prev == null)
            {
                Head = next; //reset the head as the next item of the head node
                if (Head != null)
                {
                    Head.Previous = null; //set the value of the previous to null since it was removed.
                }
            }
            else
            {
                //its not the head, its in the middle
                prev.Next = next;
            }

            //if we are removing the tail
            if (next == null)
            {
                Tail = prev; //reset the tail property of the linked list
                if (Tail != null)
                {
                    Tail.Next = null; //update the next prop to null since it was removed.
                }
            }
            else
            {
                //its not the tail
                next.Previous = prev;
            }

            Count--; //decrement 
            return true;

        }

        //https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator?view=net-6.0
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }
    }

}
