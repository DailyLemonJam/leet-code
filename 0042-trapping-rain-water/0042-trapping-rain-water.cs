public class Solution
{
    public int Trap(int[] height)
    {
        int maxIndex = 0;
        int result = 0;

        for (int i = 1; i < height.Length; i++)
        {
            if (height[i] > height[maxIndex]) maxIndex = i;
        }

        int maxCurrentHeight = height[0];
        for (int i = 0; i < maxIndex; i++)
        {
            if (height[i] > maxCurrentHeight) maxCurrentHeight = height[i];
            else result += maxCurrentHeight - height[i];
        }

        maxCurrentHeight = height[^1];
        for (int i = height.Length - 1; i > maxIndex; i--)
        {
            if (height[i] > maxCurrentHeight) maxCurrentHeight = height[i];
            else result += maxCurrentHeight - height[i];
        }

        return result;
    }
}