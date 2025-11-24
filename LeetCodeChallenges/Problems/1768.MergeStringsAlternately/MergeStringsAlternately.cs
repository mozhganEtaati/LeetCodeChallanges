using System.Text;

namespace LeetCodeChallenges.Problems._1768.MergeStringsAlternately;

public static class MergeStringsAlternately
{
    public static string MergeAlternately(string word1, string word2)
    {
        int max = Math.Max(word1.Length, word2.Length);
        var sb = new StringBuilder(word1.Length + word2.Length);

        for (int i = 0; i < max; i++)
        {
            if (i < word1.Length)
                sb.Append(word1[i]);

            if (i < word2.Length)
                sb.Append(word2[i]);
        }

        return sb.ToString();
    }
}
