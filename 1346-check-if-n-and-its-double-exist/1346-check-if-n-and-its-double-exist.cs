public class Solution
{
    public bool CheckIfExist(int[] arr)
    {
        // better use hashmap
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (i != j)
                {
                    if (arr[i] * 2 == arr[j]) return true;
                }
            }
        }
        
        return false;
    }
}