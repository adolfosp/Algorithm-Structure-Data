namespace Algoritmos_Estrutura_Dados.LeetCode.MaxArea;

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