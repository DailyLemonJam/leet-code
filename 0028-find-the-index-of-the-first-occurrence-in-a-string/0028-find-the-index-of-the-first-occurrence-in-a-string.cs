public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (needle.Length > haystack.Length) return -1;

        int counter = 0;

        for (int i = 0, j = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle[j])
            {
                j++;
                counter++;
                if (counter == needle.Length) return i - counter + 1;
            }
            else
            {
                i -= counter;
                counter = 0;
                j = 0;
            }
        }

        return -1;
    }
}