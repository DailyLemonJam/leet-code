public class Solution
{
    public int MaximumElementAfterDecrementingAndRearranging(int[] arr)
    {
        if (arr.Length == 1) return 1;
        Array.Sort(arr);
        arr[0] = 1;
        int max = arr.Max();
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if((GetAbs(arr[i] - arr[i + 1])) > 1)
            {
                arr[i + 1] = arr[i] + 1;
                if (arr[i + 1] == max) return max;
            }
        }
        return arr.Max();
    }

    public int GetAbs(int i)
    {
        int m = i >> 31;
        return ((i + m) ^ m);
    }
}