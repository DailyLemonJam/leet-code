public class Solution
{
    public bool CloseStrings(string word1, string word2)
    {
        if (word1.Length != word2.Length) return false;

        var d1 = new Dictionary<char, int>();
        var d2 = new Dictionary<char, int>();

        for (int i = 0; i < word1.Length; i++)
        {
            if (!d1.TryAdd(word1[i], 1)) d1[word1[i]]++;
            if (!d2.TryAdd(word2[i], 1)) d2[word2[i]]++;
        }

        if (d1.Count != d2.Count) return false;

        var set = new HashSet<char>();
        foreach (var pair in d1)
        {
            set.Add(pair.Key);
        }
        foreach (var pair in d2)
        {
            if (!set.Contains(pair.Key)) return false;
        }

        var dInts = new Dictionary<int, int>();
        foreach (var pair in d1)
        {
            if (!dInts.TryAdd(pair.Value, 1)) dInts[pair.Value]++;
        }
        foreach (var pair in d2)
        {
            if (dInts.ContainsKey(pair.Value)) dInts[pair.Value]--;
        }

        foreach (var pair in dInts)
        {
            if (pair.Value != 0) return false;
        }

        return true;
    }
}