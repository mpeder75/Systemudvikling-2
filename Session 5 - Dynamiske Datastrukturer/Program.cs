using System;

// Her oprettes instans af LinkedList
LinkedList s = new LinkedList();  // 1

// Her tilføjes elementer til LinkedList
s.Add(3);   // 3.
s.Add(7);
s.Add(5);
s.Add(6);
s.PrintAll();


class LinkedList
{
    private Node head;

    public LinkedList()
    {
        head = null;  // 2. 
    }

    public void Add(int data)  // 4.
    {
        Node toAdd = new Node(data,head);
        head = toAdd;
    }

    public void PrintAll()  // 6.
    {
        Node current = head;
        while (current != null)
        {
            Console.WriteLine("tmp.data =" + current.Data);
            current = current.Next;
        }
    }
}


public class Node // 5
{
    public int Data { get; }
    public Node Next { get; }

    public Node(int data, Node next)
    {
        this.Data = data;
        this.Next = next;
    }
}
