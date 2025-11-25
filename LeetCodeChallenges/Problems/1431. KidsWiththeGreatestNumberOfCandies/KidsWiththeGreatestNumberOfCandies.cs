namespace LeetCodeChallenges.Problems._1431._KidsWiththeGreatestNumberOfCandies;

public static class KidsWiththeGreatestNumberOfCandies
{
    public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        List<bool> result = new();
        int max = 0;
        for (int i = 0; i < candies.Length; i++)
        {
            if (max < candies[i]) { max = candies[i]; }
        }

        for (int i = 0; i < candies.Length; i++)
        {
            result.Add(candies[i] + extraCandies >= max);
        }

        return result;
    }
}
