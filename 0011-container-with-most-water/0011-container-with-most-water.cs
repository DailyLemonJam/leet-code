public class Solution
{
    public int MaxArea(int[] height)
    {
        int maxV = 0;

        int left = 0;
        int right = height.Length - 1;

        while (left < right)
        {
            int currentV = (right - left) * Math.Min(height[left], height[right]);
            if (currentV > maxV)
            {
                maxV = currentV;
            }

            if (height[left] < height[right]) left++;
            else right--;
        }

        return maxV;
    }
}