public class Solution
{
    public string SortVowels(string s)
    {
        var containedVowels = new List<char>();
        var sb = new StringBuilder();
        //string vowels = "aeiouAEIOU";
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};

        for (int i = 0; i < s.Length; i++)
        {
            if (vowels.Contains(s[i]))
            {
                containedVowels.Add(s[i]);
            }
        }
        containedVowels.Sort();
        for (int i = 0; i < s.Length; i++)
        {
            if (vowels.Contains(s[i]))
            {
                sb.Append(containedVowels[0]);
                containedVowels.RemoveAt(0);
            }
            else sb.Append(s[i]);
        }
        return sb.ToString();
    }
}