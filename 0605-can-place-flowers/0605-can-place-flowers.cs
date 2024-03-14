public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int counter = 0;
        bool leftOk = false;
        bool rightOk = false;

        for (int i = 0; i < flowerbed.Length; i++)
        {
            if (flowerbed[i] == 0)
            {
                if (i > 0)
                {
                    if (flowerbed[i - 1] == 0) leftOk = true;
                }
                else leftOk = true;
                
                if (i < flowerbed.Length - 1)
                {
                    if (flowerbed[i + 1] == 0) rightOk = true;
                }
                else rightOk = true;
                
                if (leftOk && rightOk)
                {
                    counter++;
                    i++;
                }
            }
            leftOk = false;
            rightOk = false;
        }

        return counter >= n ? true : false;
    }
}