
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
myTree.Insert(17);


myTree.traverseInOrder();

// søge efter værdien 27, findes den returneres den 
Console.WriteLine("\n");
TreeNode.Print(myTree.Get(27));
TreeNode.Print(myTree.Get(17));
TreeNode.Print(myTree.Get(8888));

// finde min værdi
Console.WriteLine("\nMin value: " + myTree.Min());

// finde max værdi
Console.WriteLine("\nMax value: " + myTree.Max());


class TreeNode
{
    public int Data { get; set; }
    public TreeNode LeftChild { get; set; }
    public TreeNode RightChild { get; set; }

    public TreeNode(int data)
    {
        this.Data = data;
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

    // Get specifikt tal fra tree
    public TreeNode Get(int value)
    {
        if (value == Data) // Hvis det vi søger efter er lig med værdien af root, returneres value
        {
            return this;
        }
        // Hvis value er mindre end node, vil der søges i venstre subtree child
        if (value < Data)
        {
            if (LeftChild != null) // Hvis der er et left child
            {
                return LeftChild.Get(value); // returneres dents værdi
            }
        }
        else // Hvis value er større end Data, søges der i højre subtree child
        {
            if (RightChild != null)
            {
                return RightChild.Get(value);
            }
        }

        // Hvis den value man søger efter ikke findes i tree, returneres null
        return null;
    }

    // Get min - søger fra root og nedad
    public int Min()
    {
        if (LeftChild == null) // HVIS root ikke har en leftchild, returneres værdien af root (da højreside skal være større)
        {
            return Data;
        }
        else // Hvis LeftChild eksistere, søges i dents venstre child (rekursion)
        {
            return LeftChild.Min();
        }     
    }

    // Get Max - søger fra Root og nedad
    public int Max()
    {
        if (RightChild == null) // Hvisroot ikek har har rightchild er roots værdi Max værdi (da venstre side SKAL være mindre)
        {
            return Data;
        }
        else
        {
            return RightChild.Max();
        }  
    }


    public void treaverseInOrder()
    {
        if (LeftChild != null)
        {
            LeftChild.treaverseInOrder();
        }
        Console.Write($"{Data} ");

        if (RightChild != null)
        {
            RightChild.treaverseInOrder();
        }
    }

    public static void Print(TreeNode node)
    {
        if (node != null)
        {
            Console.WriteLine(node.Data);
        }
        else
        {
            Console.WriteLine($"Node not found");
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

    public TreeNode Get(int value)
    {
        if (root != null)
        {
            return root.Get(value);
        }
        return null;
    }

    // Get Min
    public int Min()
    {
        if (root == null) // Hvis træet er tomt, returneres den mindste integer værdi, 
        {
            return int.MinValue;
        }
        else // Ellers returneres værdien .Min() finder
        {
            return root.Min();
        }
    }

    // Get Max
    public int Max() 
    {
        if(root == null)
        {
            return int.MaxValue;
        } else
        {
            return root.Max();
        }
    
    }


    public void traverseInOrder()
    {
        if (root != null)
        {
            root.treaverseInOrder();
        }
    }
}