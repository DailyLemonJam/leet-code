public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        var d = new Dictionary<int, int>();
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (!d.TryAdd(arr[i], 1)) d[arr[i]]++;
        }

        var set = new HashSet<int>();

        foreach (var pair in d)
        {
            if (!set.Add(pair.Value)) return false;
        }

        return true;
    }
}