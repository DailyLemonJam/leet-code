public class Solution
{
    public string ReverseWords(string s)
    {
        var result = new StringBuilder();
        var stack = new Stack<string>();
        var tempString = new StringBuilder();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != ' ')
            {
                while (i < s.Length && s[i] != ' ')
                {
                    tempString.Append(s[i]);
                    i++;
                }
                stack.Push(tempString.ToString());
                tempString.Clear();
            }
        }

        while (stack.Count > 1)
        {
            result.Append(stack.Pop());
            result.Append(' ');
        }
        result.Append(stack.Pop());

        return result.ToString();
    }
}