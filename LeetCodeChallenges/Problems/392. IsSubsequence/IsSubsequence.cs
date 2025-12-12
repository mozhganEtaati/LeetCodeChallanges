namespace LeetCodeChallenges.Problems._392._IsSubsequence;

public static class IsSubsequence
{
    public static bool IsSubsequenceStrings(string s, string t)
    {
        var sPointer = 0;

        for (int i = 0; i < t.Length && sPointer < s.Length; i++)
        {
            if (t[i] == s[sPointer])
            {
                sPointer++;
            }
        }

        return sPointer == s.Length;
    }
}
