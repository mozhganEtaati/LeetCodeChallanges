using System.Text;

namespace LeetCodeChallenges.Problems._151.ReverseWordsInaString;

public static class ReverseWordsInaString
{
    public static string ReverseWords(string s)
    {
        List<string> words = new List<string>();

        StringBuilder stringBuilder = new StringBuilder();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ' && i != 0)
            {
                if (stringBuilder.Length > 0)
                {
                    words.Add(stringBuilder.ToString());
                    stringBuilder = new StringBuilder();
                }
                continue;
            }

            if (s[i] == ' ' && i == 0)
                continue;

            if (i == s.Length - 1)
            {
                stringBuilder.Append(s[i]);
                words.Add(stringBuilder.ToString());
                stringBuilder = new StringBuilder();
                break;
            }

            stringBuilder.Append(s[i]);
        }

        for (int i = 0; i < words.Count; i++)
        {
            stringBuilder.Append(words[words.Count - 1 - i]);
            if (i != words.Count - 1)
                stringBuilder.Append(' ');
        }

        return stringBuilder.ToString();
    }

}
