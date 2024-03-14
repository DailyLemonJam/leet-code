public class Solution {
    public int FindSpecialInteger(int[] arr) {
        int counter = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                counter++;
                if ((counter + 1) * 4 > arr.Length) return arr[i];
            }
            else counter = 0;
        }

        return arr[^1];
    }
}