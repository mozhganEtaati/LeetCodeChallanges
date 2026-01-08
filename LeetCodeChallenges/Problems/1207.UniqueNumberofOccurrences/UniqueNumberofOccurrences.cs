namespace LeetCodeChallenges.Problems._1207.UniqueNumberofOccurrences;

public static class UniqueNumberofOccurrences
{
    public static bool UniqueOccurrences(int[] arr)
    {
        var freq = new Dictionary<int, int>();
        var seen = new HashSet<int>();

        foreach (var n in arr)
        {
            freq[n] = freq.GetValueOrDefault(n) + 1;
        }

        foreach (var c in freq.Values)
        {
            if (!seen.Add(c))
                return false;
        }

        return true;
    }
}
