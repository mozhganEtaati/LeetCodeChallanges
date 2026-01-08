namespace LeetCodeChallenges.Problems._724.FindPivotIndex;

public static class FindPivotIndex
{
    public static int PivotIndex(int[] nums)
    {
        int totalSum = 0;
        foreach (var num in nums)
            totalSum += num;

        int leftSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int rightSum = totalSum - leftSum - nums[i];

            if (leftSum == rightSum)
                return i;

            leftSum += nums[i];
        }

        return -1;
    }
}
