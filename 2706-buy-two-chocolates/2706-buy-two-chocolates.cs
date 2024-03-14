public class Solution {
    public int BuyChoco(int[] prices, int money) {
        Array.Sort(prices);
        int res = money - prices[0] - prices[1];
        return res >= 0 ? res : money;
    }
}