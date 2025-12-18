namespace LeetCodeChallenges.Problems._1679.MaxNumberofK_SumPairs;

public static class MaxNumberofK_SumPairs
{
    public static int MaxOperations(int[] nums, int k)
    {
        Array.Sort(nums);

        int numberOfOperations = 0;
        int i = 0;
        int j = nums.Length - 1;

        while (i < j)
        {
            var sum = nums[i] + nums[j];
            if (sum == k)
            {
                numberOfOperations++;
                j--;
                i++;
            }
            else if (sum < k)
            {
                j--;

            }
            else
            {

                i++;
            }
        }

        return numberOfOperations;
    }
}
