public class Solution
{
    public string RemoveStars(string s)
    {
        var stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != '*') stack.Push(s[i]);
            else stack.Pop();
        }

        var result = new StringBuilder();

        while (stack.Count > 0)
        {
            result.Insert(0, stack.Pop());
        }

        return result.ToString();
    }
}