namespace LeetCodeChallenges.Problems._1732.FindtheHighestAltitude;

public static class FindtheHighestAltitude
{
    public static int LargestAltitude(int[] gain)
    {
        int max = 0;
        int maxAltitude = 0;
        int i = 0;
        while (i < gain.Length)
        {
            maxAltitude += gain[i];

            if (maxAltitude > max)
                max = maxAltitude;

            i++;
        }
        return max;
    }
}
