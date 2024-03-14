public class Solution
{
    public string DestCity(IList<IList<string>> paths)
    {
        var set = new HashSet<string>();
        int dist = paths.Count;

        for (int i = 0; i < dist; i++)
        {
            set.Add(paths[i][0]);
        }

        for (int i = 0; i < dist; i++)
        {
            if (!set.Contains(paths[i][1])) return paths[i][1];
        }

        return paths[^1][0];
    }
}