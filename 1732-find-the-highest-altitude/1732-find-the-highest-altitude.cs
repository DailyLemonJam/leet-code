public class Solution {
    public int LargestAltitude(int[] gain) {
        int max = 0;
        int currentHeight = 0;

        for (int i = 0; i < gain.Length; i++)
        {
            currentHeight += gain[i];
            if (currentHeight > max) max = currentHeight;
        }

        return max;
    }
}