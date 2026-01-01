namespace LeetCodeChallenges._1493.LongestSubarrayof1_sAfterDeletingOneElement;

public static class LongestSubarrayof1_sAfterDeletingOneElement
{
    public static int LongestSubarray(int[] nums, int k)
    {
        int left = 0, right = 0, max = 0, firstzeroIndex = -1;

        while (right < nums.Length)
        {
            if (nums[right] == 0)
            {
                if (firstzeroIndex != -1)
                {
                    left = firstzeroIndex++;
                }

                firstzeroIndex = right;
            }

            var winSize = right - left + 1;
            if (winSize > max)
                max = winSize;

            right++;
        }

        return max - 1;
    }
}
