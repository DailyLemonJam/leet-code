public class Solution {
    public int MaximumWealth(int[][] accounts) {
        int max = 0;
        int current = 0;
        for (int i = 0; i < accounts.Length; i++)
        {
            for (int j = 0; j < accounts[i].Length; j++)
            {
                current += accounts[i][j];
            }
            if (current > max) max = current;
            current = 0;
        }
        return max;
    }
}