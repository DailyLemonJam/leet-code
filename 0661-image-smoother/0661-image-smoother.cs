public class Solution {
    public int[][] ImageSmoother(int[][] img) {
        int[][] result = new int[img.Length][];

        for (int i = 0; i < img.Length; ++i) 
        {
            result[i] = new int[img[0].Length];

            for (int j = 0; j < img[0].Length; ++j) 
            {
                int sum = 0;
                int count = 0;

                for (int xi = Math.Max(0, i - 1); xi < Math.Min(img.Length, i + 2); xi++) 
                {
                    for (int yj = Math.Max(0, j - 1); yj < Math.Min(img[0].Length, j + 2); yj++) 
                    {
                        count++;
                        sum += img[xi][yj];
                    }
                }

                result[i][j] = sum / count;
            }
        }

        return result;
    }
}