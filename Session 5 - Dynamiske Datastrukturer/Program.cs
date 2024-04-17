using System;

// Her oprettes instans af LinkedList
LinkedList s = new LinkedList();

// Her tilføjes nodes til LinkedList
s.Add(3);
s.Add(7);
s.Add(5);
s.Add(6);

// PrintALl
s.PrintAll();

// PrintOdd
s.PrintOddNodes();

// Sum
double result = Sum(s);

double Sum(LinkedList s)
{
    throw new NotImplementedException();
}

class LinkedList
{
    private Node head;

    public LinkedList()
    {
        head = null;
    }

    public void Add(int data)
    {
        Node toAdd = new Node(data, head);
        head = toAdd;
    }

    public void PrintAll()
    {
        Node current = head;

        while (current != null) // når current er null, ved vi LinkedList er slut
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }
    }

    // Print node der har ulige data 
    public void PrintOddNodes()
    {
        Node current = head;

        while (current != null) // når current er null, ved vi LinkedList er slut
        {
            if (current.Data % 2 != 0)  // hvis data i node er ulige
            {
                Console.WriteLine($"Printing odd numbers: {current.Data}"); // printes det
            }
            current = current.Next; // dernæst sættes current node til current.Next
        }
    }

    public double Sum(LinkedList myLinkedList)
    {
        Node current = head;
        double sum = 0;

        while (current != null) // når current er null, ved vi LinkedList er slut
        {
            sum += current.Data;
            current = current.Next;
        }
        return sum;
    }


    public void DeleteNodeAtPosition(int position)
    {
        if (position <= 0 || head == null) // Check if the position is valid and the list is not empty
        {
            return; // Invalid position or empty list, nothing to delete
        }

        if (position == 1) // Special case: deleting the head node
        {
            head = head.Next;
            return;
        }

        Node current = head;
        Node previous = null;
        int currentPosition = 1;

        // Traverse the list to find the node at the specified position
        while (current != null && currentPosition < position)
        {
            previous = current;
            current = current.Next;
            currentPosition++;
        }

        if (current != null) // Check if the node at the specified position exists
        {
            // Delete the node at the specified position by updating the references
            previous.Next = current.Next;
        }
    }


    public void InsertAfterNode(Node nodeToInsertAfter, int newData)
    {
        if (nodeToInsertAfter == null)
        {
            // Cannot insert after a null node
            return;
        }

        // Create the new node with the given data
        Node newNode = new Node(newData, null);

        // Set the next reference of the new node to the next node of the node to insert after
        newNode.Next = nodeToInsertAfter.Next;

        // Update the next reference of the node to insert after to point to the new node
        nodeToInsertAfter.Next = newNode;
    }





    public class Node
    {
        public int Data { get; }
        public Node Next { get; set; }

        public Node(int data, Node next)
        {
            this.Data = data;
            this.Next = next;
        }
    }
}