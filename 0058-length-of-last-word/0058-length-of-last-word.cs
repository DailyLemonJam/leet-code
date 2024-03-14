public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int counter = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] != ' ') counter++;
            else
            {
                if (counter != 0) return counter;
            }
        }
        return counter;
    }
}