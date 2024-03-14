using System.Text;

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var map = new Dictionary<string, List<string>>();

        for (int str = 0; str < strs.Length; str++)
        {
            var wordMap = new SortedDictionary<char, int>();

            for (int ch = 0; ch < strs[str].Length; ch++)
            {
                if (!wordMap.TryAdd(strs[str][ch], 1))
                {
                    wordMap[strs[str][ch]]++;
                }
            }

            var wordHash = GetWordHash(wordMap);

            if (!map.TryAdd(wordHash, new List<string>() { strs[str] }))
            {
                map[wordHash].Add(strs[str]);
            }
        }

        var result = new List<IList<string>>();

        foreach (var pair in map)
        {
            result.Add(pair.Value);
        }

        return result;
    }

    private string GetWordHash(SortedDictionary<char, int> dic)
    {
        var result = new StringBuilder();

        foreach (var pair in dic)
        {
            result.Append(pair.Key);
            result.Append(pair.Value);
        }

        return result.ToString();
    }

}