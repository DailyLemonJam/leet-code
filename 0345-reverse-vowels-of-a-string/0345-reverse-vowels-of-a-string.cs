public class Solution
{
    public string ReverseVowels(string s)
    {
        string vowels = "aeiouAEIOU";
        var result = new StringBuilder();
        var stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (vowels.Contains(s[i])) stack.Push(s[i]);
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (vowels.Contains(s[i])) result.Append(stack.Pop());
            else result.Append(s[i]);
        }

        return result.ToString();
    }
}