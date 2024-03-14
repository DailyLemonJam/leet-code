public class Solution {
    public bool IsValid(string s)
    {
        if (s.Length == 1) return false;
        var stack = new Stack<char>();
        char chr;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                stack.Push(s[i]);
            }
            else
            {
                if (stack.Count == 0) return false;
                chr = stack.Pop();
                if (chr == '(' && s[i] != ')') return false;
                if (chr == '{' && s[i] != '}') return false;
                if (chr == '[' && s[i] != ']') return false;
            }
        }
        return stack.Count == 0 ? true : false;
    }
}