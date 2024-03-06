// instans af Tree Class
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

// Tree traverses - værdier der er tilføjet ovenfor skull gerne returneres sorteret efter InOrder
myTree.traverseInOrder();

// søge efter værdien 27, findes den returneres den 
Console.WriteLine("\n");
TreeNode.Print(myTree.Get(27));
TreeNode.Print(myTree.Get(17));
TreeNode.Print(myTree.Get(8888));

// finde min værdi
Console.WriteLine($"\nMin value: {myTree.Min()}");

// finde max værdi
Console.WriteLine($"\nMax value is: {myTree.Max()}");

// find sum
Console.WriteLine($"\nSum is: {myTree.Sum()}\n");

// forsøger at indsætte en duplikering
myTree.Insert(17);

// PrintLeaves()
Console.WriteLine("\nLeafs:");
myTree.PrintLeaves();



// 1. TreeNode class - Står for validering, traversal, Min, Max, Sum, Insert af nodes
class TreeNode
{
    public int Data { get; set; }                 // data for noden ex. 15
    public TreeNode LeftChild { get; set; }       // ref til left child
    public TreeNode RightChild { get; set; }      // ref til right child
    public TreeNode root { get; set; }

    public TreeNode(int data)
    {
        this.Data = data;
    }

    // Insert
    public void Insert(int value)
    {
        if (value == Data) // hvis værdi der ønskes indsat er lig med root - duplikering
        {
            Console.WriteLine("Ingen duplikanter, tak");
            return;
        }

        if (value < Data)   // hvis værdi der ønskes indsættes er mindre end root, gås til venstre child
        {
            if (LeftChild == null)  // Hvis der ikke er et left child til root, laves nyt og value indsættes
            {
                LeftChild = new TreeNode(value);
            }
            else  // HVIS root node har et left child, kaldes insert method på left child
            {
                LeftChild.Insert(value);   // når denne kaldes, vil der så igen blive valideret (recursion)
            }
        }
        else   // Hvis værdi der ønskes indsættes er større end node 
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

    // Get one
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
        return null;
    }

    // Get Sum
    public int Sum(TreeNode node)
    {
        int sum;

        if (node == null)
        {
            return -1;
        }
        else
        {
            sum = node.Data;

            if (LeftChild != null)  // hvis der er en LeftChild, vil det traverses
            {
                sum += LeftChild.Sum(LeftChild); // rekursivt kald der kalder venstre del a tree og summere op
            }

            if (RightChild != null)  // Hvis der er en RightChild, EFTER Leftchild er tjekket, tjekkes rightside
            {
                sum += RightChild.Sum(RightChild); // rekursivt kald der kalder venstre del a tree og summere op
            }
        }
        return sum;
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
        if (RightChild == null) // Hvis root e har har rightchild er roots værdi Max værdi (da venstre side SKAL være mindre)
        {
            return Data;
        }
        else
        {
            return RightChild.Max(); // HVIS rightChild eksistere kaldes Max() (rekursiv) og tjekker om der er rightChild på den næste
        }
    }

    // Print Leaves
    public static void PrintLeaves(TreeNode node)
    {
        if (node == null) // Hvis første node er null
        {
            return;
        }
        // Hvis nuværendne node er et leaf, printes det (det har ingen children)
        if (node.LeftChild == null && node.RightChild == null)
        {
            TreeNode.Print(node);
        }

        // Ellers traverses tree igen på venstreside, og når det er førdigt
        PrintLeaves(node.LeftChild);

        // Traverser der rekursivt på højre del
        PrintLeaves(node.RightChild);
    }

    // In Order -> Left child, derefter Root, derefter right child til root
    public void treaverseInOrder()
    {
        if (LeftChild != null)  // hvis der er en LeftChild i forvejen, vil vi traverse leftchild
        {
            LeftChild.treaverseInOrder();  // kalder sig selv igen (recursion) og tjekker om der er endnu et leftchild
        }
        Console.Write($"{Data} ");

        if (RightChild != null)  // Hvis der er en RightChild, EFTER Leftchild er tjekket, tjekkes rightside
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


// 2. Tree class - repræsentere selve træet
class Tree
{
    // root node, er der adgang til root node kan alt andet tilgåes derigennem
    public TreeNode root { get; set; }

    // insert
    // TreeNodeder kalder denne med den validerede node
    public void Insert(int value)
    {
        if (root == null)  // hvis root er nul -> tree er tomt, sættes value til at være root
        {
            root = new TreeNode(value);
        }
        else  // Hvis root eksisterer, skal der valideres igen - Her genbruges insert metoden fra TreeNode class
        {
            root.Insert(value);  // når denne kaldes, vil der så igen blive valideret i TreeNode class (recursion)
        }
    }

    // Traverse tree
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
        if (root == null)
        {
            return int.MinValue;
        }
        else
        {
            return root.Max();
        }
    }

    // Sum
    public int Sum()
    {
        if (root == null)
        {
            return 0;
        }
        else
        {
            return root.Sum(root);
        }
    }

    // TraverseInOrder
    // In Order -> Left child, derefter Root, derefter right child til root
    public void traverseInOrder()
    {
        if (root != null)  // hvis der er en root, vil tree blive traverset med InOrder
        {
            root.treaverseInOrder();
        }
    }

    public void PrintLeaves()
    {
        TreeNode.PrintLeaves(root);
    }


}

