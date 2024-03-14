public class Solution
{
    public bool MakeEqual(string[] words)
    {
        var d = new Dictionary<char, int>();

        for (int i = 0; i < words.Length; i++)
        {
            for (int j = 0; j < words[i].Length; j++)
            {
                if (!d.TryAdd(words[i][j], 1)) d[words[i][j]]++;
            }
        }

        foreach (var pair in d)
        {
            if (pair.Value % words.Length != 0) return false;
        }

        return true;
    }
}