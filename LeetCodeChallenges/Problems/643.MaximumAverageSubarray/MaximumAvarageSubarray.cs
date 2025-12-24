namespace LeetCodeChallenges.Problems._643.MaximumAverageSubarray;

public static class MaximumAvarageSubarray
{
    public static double FindMaxAverage(int[] nums, int k)
    {
        int windowSum = 0;
        int i = 0;

        for (; i < k; i++)
        {
            windowSum += nums[i];
        }

        int max = windowSum;

        for (; i < nums.Length; i++)
        {
            windowSum += nums[i];
            windowSum -= nums[i - k];
            if (windowSum > max)
                max = windowSum;
        }

        return (double)max / k;
    }
}
