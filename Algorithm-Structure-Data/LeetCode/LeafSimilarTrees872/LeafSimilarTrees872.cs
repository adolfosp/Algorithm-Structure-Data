public class LeafSimilarTrees872
{
    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        List<int> leafsRoot1 = new List<int>();
        List<int> leafsRoot2 = new List<int>();

        GetLastLeafOfRoot(root1, leafsRoot1);
        GetLastLeafOfRoot(root2, leafsRoot2);

        return Enumerable.SequenceEqual(leafsRoot1, leafsRoot2);
    }

    private void GetLastLeafOfRoot(TreeNode root1, List<int> leafsRoot1)
    {
        // o segredo está na recursividade, porque ele vai indo no caminho da esquerda até finalizar as folhas, depois passa o elemento da direita do último nó
        // se não tiver nada, ele vai voltar para a primeira chamada da recursividade, ou seja, o primeiro lado esquerdo e vai passar para o lado direito

        if (root1 != null)
        {
            GetLastLeafOfRoot(root1.Left, leafsRoot1);
            if (root1.Left == null && root1.Right == null)
            {
                leafsRoot1.Add(root1.Value);
            }
            GetLastLeafOfRoot(root1.Right, leafsRoot1);
        }
    }
}

public class TreeNode
{
    public int Value;
    public TreeNode Left;
    public TreeNode Right;

    public TreeNode(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}

public class BinaryTree
{
    public TreeNode Root;

    public void Insert(int value)
    {
        Root = InsertRecursive(Root, value);
    }

    private TreeNode InsertRecursive(TreeNode current, int value)
    {
        if (current == null)
        {
            // significa que é o primeiro registro
            return new(value);
        }

        // se não for o primeiro registro, começa a construir as folhas
        //a ordenação é feita a nível do root e a folha esqueda e direita
        if (value < current.Value)
        {
            current.Left = InsertRecursive(current.Left, value);
        }
        else if (value > current.Value)
        {
            current.Right = InsertRecursive(current.Right, value);
        }

        return current;
    }

}
