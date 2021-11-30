# Linked Lists

## What do they consist of?
Linked Lists consists of a chain of Nodes. One node references next node and the next references the following node. 

You have to traverse the Linked List so to get to the ith item.

## Why is it valuable?
When arrays are defined the amount of space they take up in Memory needs to be specified. You can't just create an array without providing a space for it. The compute has to allocate that space so that data can be stored in memory together. Those memory addresses are close to one another. But what if you just wanted to have a collection and you have no knowledge of how big it will be? You could recreate and copy an array once it gets to be large enough (i think Java does this).

Linked Lists are valuable because they offer up a solution to solve the problem of realloacting memory to store the values.

## How is it implemented?
It consists of Nodes that just reference the next Node

## Singly and Doubly Linked
The doubly linked list but has a reference to the previous node. In this way you can iterate through and either end of the code.

## Implementing a Doubly Linked List
A Doubly Linked List class will use the Doubly Linked List Node which stores a reference to the previous and next items. 

```C#
public class DoublyLinkedListNode<T>
{
    public DoublyLinkedListNode(T value)
    {
        this.Value = value;
    }

    public T Value { get; set; }
    public DoublyLinkedListNode<T> Next { get; set; }
    public DoublyLinkedListNode<T> Previous { get; set; }
}
```

The Doubly Linked List class will handle the assignments for the next and previous references to the nodes. It will also inherit from the ```System.Collections.Generic.ICollection``` so that we can work with it as a collection.

### Adding to the head or tail
Consider the head to be the left most element in a Linked List where as the tail is the right most element in a linked list.

| Head  |  Item | Item  | Item  |  Tail |
|-      |-      |-      |-      |-      |

If we add to the head, the tail remains stable. Below is the code that outlines the AddHead method for a doubly Linked List.

```C#
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
```

Consider that the next is a pointer to the right, where as the previous property is a pointer to the left of a linked list. First a new node to represent the item being added is created. Then we update it's next pointer to the current head. If the head is not null, then the current head's previous reference is set to the item being added (toAdd). 

At the point where the code says ```Head = toAdd``` we've updated all of the necessary references so all that is left to do is set the added item as the new head.

### Example

Take the current state of our Linked List with one node that has the value "World". 

|  Head |
|-      |
| Value = "World" Previous = null Next = null |

If we wanted to add "Hello" to the Head we would call AddHead("Hello"), which then would update the current head and set the added item as the new head for the Doubly Linked List.

|Head|  Tail |
|-      |-      |
| Value = "Hello" Previous = null Next = prev Head | Value = "World" Previous = null Next = null |

Then we wanted to add another word, AddHead("Hoy")

|Head|- |  Tail |
|-|-      |-      |
|Value = "Hoy" Previous = null Next = prev Head | Value = "Hello" Previous = null Next = tail | Value = "World" Previous = null Next = null |

Notice how the tail always stays the same while the head gets updated, and the only items we touch is the head. The time complexity of this item would be O(1), constant time.

## Finding Items
When you are looking for items in the list

## Examples in the Wild?
Some examples include:
- The middleware pipeline in Asp.Net Core
- The List implementation in C# (I think?) 