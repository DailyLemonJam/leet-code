public class Solution {
    public int TotalMoney(int n) {
        // better do that with arithmetic progression formulas tho
        int sum = 0;
        
        for (int i = 1; i < n + 1; i++)
        {
            // (n / 7) - current week
            // (n % 7) - current day
            sum += (i % 7) + (i / 7);
        }
        sum += 6 * (n / 7);

        return sum;
    }
}