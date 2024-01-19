# Intuition
The problem aims to check if the last leafs of two tree are equal

# Approach
- The algorithm performs a deep traversal (Depth-first Traversal) in both trees, collecting leaf values (childless nodes).

# Complexity
- Time complexity:
O(n1 + n2), where n1 and n2 are the total of tree. We navigate each tree once during the depth-first traversal.

- Space complexity:
O(n1 + n2), where n1 + n2 are the nodes of trees
# Code
```

public class Solution {
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
        if (root1 != null)
        {
            GetLastLeafOfRoot(root1.left, leafsRoot1);
            if (root1.left is null && root1.right is null)
            {
                leafsRoot1.Add(root1.val);
            }
            GetLastLeafOfRoot(root1.right, leafsRoot1);
        }
    }
}
```