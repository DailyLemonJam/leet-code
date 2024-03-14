public class Solution
{
    public bool IsHappy(int n)
    {
        var set = new HashSet<int>();

        while (set.Add(n))
        {
            if (n == 1) return true;
            n = SumOfDigits(n);
        }

        return false;
    }

    private int SumOfDigits(int n)
    {
        int res = 0;

        while (n > 0)
        {
            int cur = n % 10;
            res += cur * cur;
            n /= 10;
        }

        return res;
    }
}