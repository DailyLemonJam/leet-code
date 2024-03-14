public class Solution
{
    public int NumRollsToTarget(int n, int k, int target)
    {
        int mod = 1000000007;
        var cache = new Dictionary<ValueTuple<int, int>, int>();

        int CountNext(int n, int target)
        {
            if (n < 0) return 0;
            if (n == 0) return target == 0 ? 1 : 0;
            if (cache.ContainsKey((n, target))) return cache[(n, target)];

            int result = 0;
            for (int i = 1; i <= k; i++)
            {
                result = (result + CountNext(n - 1, target - i)) % mod;
            }
            cache.Add((n, target), result);

            return result;
        }

        return CountNext(n, target);
    }

}