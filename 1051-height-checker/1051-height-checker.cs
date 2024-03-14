public class Solution
{
    public int HeightChecker(int[] heights)
    {
        int counter = 0;

        int[] temp = new int[heights.Length];
        Array.Copy(heights, temp, heights.Length);
        Array.Sort(temp);

        for (int i = 0; i < heights.Length; i++)
        {
            if (heights[i] != temp[i]) counter++;
        }

        return counter;
    }
}