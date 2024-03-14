public class Solution
{
    private HashSet<int> _cache = new();

    public int Fib(int n)
    {
        if (_cache.Contains(n)) return n;

        if (n < 2) return n;

        int res;
        res = Fib(n - 1) + Fib(n - 2);

        return res;
    }
}