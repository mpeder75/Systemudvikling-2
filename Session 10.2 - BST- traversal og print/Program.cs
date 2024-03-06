
Tree myTree = new Tree();

myTree.Insert(25);
myTree.Insert(20);
myTree.Insert(15);
myTree.Insert(27);
myTree.Insert(30);
myTree.Insert(29);
myTree.Insert(26);
myTree.Insert(22);
myTree.Insert(32);


// Tree traverses - værdier der er tilføjet ovenfor skull gerne returneres sorteret efter InOrder5
myTree.traverseInOrder();


class TreeNode
{
    public int Data { get; set; }              
    public TreeNode LeftChild { get; set; }     
    public TreeNode RightChild { get; set; }   

    public TreeNode(int data)
    {
        Data = data;
    }

    public void Insert(int value)
    {
        if (value == Data)
        {
            Console.WriteLine("Ingen duplikanter, tak");
            return;
        }

        if (value < Data)
        {
            if (LeftChild == null)
            {
                LeftChild = new TreeNode(value);
            }
            else
            {
                LeftChild.Insert(value);
            }
        }
        else
        {
            if (RightChild == null)
            {
                RightChild = new TreeNode(value);
            }
            else
            {
                RightChild.Insert(value);
            }
        }
    }
    // In Order -> Left child, derefter Root, derefter right child til root
    public void treaverseInOrder()
    {
        if (LeftChild != null) // hvis der er en LeftChild i forvejen, vil vi traverse leftchild
        {
            LeftChild.treaverseInOrder(); // kalder sig selv igen (recursion) og tjekker om der er endnu et leftchild
        }
        Console.Write($"{Data} ");

        if (RightChild != null) // Hvis der er en RightChild, EFTER Leftchild er tjekket, tjekkes rightside
        {
            RightChild.treaverseInOrder();
        }
    }

}

class Tree
{
    public TreeNode root { get; set; }

    public void Insert(int value)
    {
        if (root == null)
        {
            root = new TreeNode(value);
        }
        else
        {
            root.Insert(value);
        }
    }

    // metode der traverse tree
    public void traverseInOrder()
    {
        if (root != null) // hvis der er en root, vil tree blive traverset med InOrder
        {
            root.treaverseInOrder();
        }

    }
}