public class Solution {
    public int MaxCoins(int[] piles) {
        Array.Sort(piles);
        int sum = 0;
        for (int i = 0, j = piles.Length - 2; i < piles.Length / 3; i++, j -= 2)
        {
            sum += piles[j];
        }
        GC.Collect();
        return sum;
    }
}