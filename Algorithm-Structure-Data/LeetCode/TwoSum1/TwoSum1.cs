namespace Algoritmos_Estrutura_Dados.LeetCode.TwoSum1;

public class TwoSum1
{
    public int[] TwoSum(int[] nums, int target)
    {

        Dictionary<int, int> seen = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];

            if (seen.ContainsKey(diff))
            {
                return [seen[diff], i];
            }
            else
            {
                seen[nums[i]] = i;
            }
        }

        return [];

    }
}
