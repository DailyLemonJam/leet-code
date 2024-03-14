public class Solution
{
    public bool IsPathCrossing(string path)
    {
        var set = new HashSet<(int,int)>() { (0,0) };

        int x = 0, y = 0;
        for (int i = 0; i < path.Length; i++)
        {
            if (path[i] == 'N') { if (!set.Add((x, ++y))) return true; }
            if (path[i] == 'S') { if (!set.Add((x, --y))) return true; }
            if (path[i] == 'E') { if (!set.Add((++x, y))) return true; }
            if (path[i] == 'W') { if (!set.Add((--x, y))) return true; }
        }

        return false;
    }
}