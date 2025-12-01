namespace LeetCodeChallenges.Problems._334.IncreasingTripletSubsequence;

public static class IncreasingTripletSubsequence
{
    public static bool IncreasingTriplet(int[] nums)
    {
        if (nums.Length <= 2)
            return false;

        var first = int.MaxValue;
        var mid = int.MaxValue;

        for (var i = 0; i < nums.Length; i++)
        {
            if (mid < nums[i])
                return true;

            if (first >= nums[i])
                first = nums[i];
            else
                mid = nums[i];
        }

        return false;
    }
}
