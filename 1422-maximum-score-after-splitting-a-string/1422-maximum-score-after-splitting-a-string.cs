public class Solution
{
    public int MaxScore(string s)
    {
        int leftZeroSum = 0;
        int rightOneSum = 0;
        int max = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '1') rightOneSum++;
        }

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == '0') leftZeroSum++;
            else rightOneSum--;
            if (rightOneSum + leftZeroSum > max) max = rightOneSum + leftZeroSum;
        }

        return max;
    }
}