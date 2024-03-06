
// instans af Tree Class - den vi vil indsætt node inf i
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





// 1. TreeNode class - Står for validering og Insert af nodes
class TreeNode
{
    public int Data { get; set; }               // data for noden ex. 15
    public TreeNode LeftChild { get; set; }     // ref til left child
    public TreeNode RightChild { get; set; }    // ref til right child

    public TreeNode(int data)
    {
        Data = data;
    }

    // insert
    public void Insert(int value)
    {
        if (value == Data)  // hvis værdi der ønskes indsat er lig med root node værdi returneres
        {
            Console.WriteLine("Ingen duplikanter, tak");
            return;
        }

        if (value < Data) // hvis værdi der ønskes indsættes er mindre end root, gås til venstre child
        {
            if (LeftChild == null) // Hvis der ikke er et left child til root, laves nyt og value indsættes
            {
                LeftChild = new TreeNode(value);
            }
            else // HVIS root node har et left child, kaldes insert method på left child
            {
                LeftChild.Insert(value); // når denne kaldes, vil der så igen blive valideret (recursion)
            }
        }
        else // Hvis værdi der ønskes indsættes er større end node 
        {
            if(RightChild == null)
            {
                RightChild = new TreeNode(value);
            }else
            {
                RightChild.Insert(value);
            }
        }
    }
}


// 2. Tree class - repræsentere selve træet
class Tree
{
    // root node, er der adgang til root node kan alt andet tilgåes derigennem
    public TreeNode root { get; set; }

    // insert - det er TreeNodeder kalder denne med den validerede node og placering, der skal placeres i Tree class
    public void Insert(int value)
    {
        if(root == null) // hvis root er nul -> tree er tomt, sættes value til at være root
        {
            root = new TreeNode(value);
        } else          // Hvis root eksisterer, skal der valideres igen - Her genbruges insert metoden fra TreeNode class
        {
            root.Insert(value); // når denne kaldes, vil der så igen blive valideret i TreeNode class (recursion)
        }
    }
}