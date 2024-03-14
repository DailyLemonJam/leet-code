public class Solution
{
    public bool ValidMountainArray(int[] arr)
    {
        if (arr.Length < 3) return false;

        int topIndex = -1;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1]) return false;

            if (arr[i] > arr[i + 1])
            {
                if (i == 0) return false;
                topIndex = i;
                break;
            }
        }

        if (topIndex == -1) return false;

        for (int i = topIndex; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1]) return false;

            if (arr[i] < arr[i + 1]) return false;
        }

        return true;
    }
}