// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] array = { 5, 3, 7, 1, 4, 6, 8 };
BinaryTree tree = new BinaryTree();

foreach (int value in array)
{
    tree.Insert(value);
}

new LeafSimilarTrees872().LeafSimilar(tree.Root);
