public class Solution
{
    public int[] ReplaceElements(int[] arr)
    {
        int max = arr[^1];

        for (int i = arr.Length - 2; i >= 0; i--)
        {
            int temp = arr[i];
            arr[i] = max;
            if (temp > max) max = temp;
        }

        arr[^1] = -1;
        return arr;
    }
}