namespace LeetCodeChallenges.Problems._443.StringCompression;

public static class StringCompression
{
    public static int Compress(char[] chars)
    {
        int basePointer = 0;

        for (int i = 0; i < chars.Length;)
        {
            char current = chars[i];
            var count = 0;

            while (i < chars.Length && current == chars[i])
            {
                i++;
                count++;
            }

            chars[basePointer++] = current;


            if (count > 1)
            {
                foreach (char c in count.ToString())
                {
                    chars[basePointer++] = c;
                }
            }

        }

        return basePointer;
    }
}
