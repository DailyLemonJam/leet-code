public class Solution {
    public int MaxProfit(int[] prices) {
        int max = 0;

        int l = 0;
        int r = 1;

        while (r != prices.Length)
        {
            if (prices[l] < prices[r])
            {
                int cur = prices[r] - prices[l];
                if (cur > max) max = cur;
            }
            else l = r;
            r++;
        }

        return max;
    }
}