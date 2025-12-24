namespace LeetCodeChallenges.Problems._1456.MaximumNumberOfVowelsInASubstringofGivenLength;

public static class MaximumNumberOfVowelsInASubstringofGivenLength
{
    public static int MaxVowels(string s, int k)
    {
        int maxVowelCount = 0;

        int windowVowelCount = 0;
        int i = 0;

        for (; i < k; i++)
        {
            if (IsVowel(s[i]))
                windowVowelCount++;
        }

        maxVowelCount = windowVowelCount;

        for (; i < s.Length; i++)
        {
            if (IsVowel(s[i]))
                windowVowelCount++;
            if (IsVowel(s[i - k]))
                windowVowelCount--;
            if (windowVowelCount > maxVowelCount)
                maxVowelCount = windowVowelCount;
        }

        return maxVowelCount;
    }

    public static bool IsVowel(char c)
    {
        switch (c)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                return true;
            default:
                return false;
        }
    }
}
