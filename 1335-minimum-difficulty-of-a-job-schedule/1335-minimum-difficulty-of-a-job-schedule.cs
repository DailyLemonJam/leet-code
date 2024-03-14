public class Solution
{
    public int MinDifficulty(int[] jobDifficulty, int d)
    {
        // just testing other solutions with small changes
        int n = jobDifficulty.Length;
        if (n < d) return -1;

        int[] dp = new int[n + 1];
        Array.Fill(dp, int.MaxValue / 2);
        dp[n] = 0;

        for (int day = 1; day <= d; day++)
        {
            for (int i = 0; i <= n - day; i++)
            {
                int maxDifficulty = 0;
                dp[i] = int.MaxValue / 2;

                for (int j = i; j <= n - day; j++)
                {
                    maxDifficulty = maxDifficulty > jobDifficulty[j] ? maxDifficulty : jobDifficulty[j];
                    dp[i] = dp[i] < maxDifficulty + dp[j + 1] ? dp[i] : maxDifficulty + dp[j + 1];
                }
            }
        }

        return dp[0];
    }
}