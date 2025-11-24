using System.Runtime.Intrinsics.X86;

namespace LeetCodeChallenges.Problems._1071.GreatestCommonDivisorofStrings;

public static class GreatestCommonDivisorofStrings
{
    public static string GcdOfStrings(string str1, string str2)
    {
        if (str1 + str2 != str2 + str1)
        {
            return "";
        }

        var gcd = GCD(str1.Length, str2.Length);
        return str1[..gcd];
    }

    private static int GCD(int a, int b)
    {
        while (b != 0)
        {
            var temp = a % b;
            a = b;
            b = temp;
        }
        return a;
    }
}
