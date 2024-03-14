public class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {
        if (str1 + str2 != str2 + str1) return "";

        int l1 = str1.Length;
        int l2 = str2.Length;
        int minLength = l1 > l2 ? l2 : l1;

        for (int i = minLength - 1; i >= 0; i--)
        {
            if (l1 % (i + 1) == 0 && l2 % (i + 1) == 0)
            {
                return str1[0..(i + 1)];
            }
        }

        return "";
    }
}