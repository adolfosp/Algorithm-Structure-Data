# Intuition
The problem aims to find the max area of container that has most water

# Approach
- The algorithm get the last positision of array(container) and do a loop getting the next element from at the beginning to calculate the area of each combination and find the max area

# Complexity
- Time complexity:
O(n)

- Space complexity:
O(1)

# Code
```
public class MaxArea11
{
    public int Solution(int[] height)
    {
        int maxArea = 0;
        int l = 0;
        int r = height.Length - 1;

        while (l < r)
        {
            maxArea = Math.Max(maxArea, Math.Min(height[l], height[r]) * (r - l));
            if (height[l] < height[r])
            {
                l++;
            }
            else
            {
                r--;
            }
        }
        return maxArea;

    }
}
```