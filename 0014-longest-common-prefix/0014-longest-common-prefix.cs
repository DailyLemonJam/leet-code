public class Solution {
    public string LongestCommonPrefix(string[] strs)
    {
        int counter = 0;
        int min = int.MaxValue;
        int id = -1;
        for (int i = 0; i < strs.Length; i++)
        {
            if (strs[i].Length < min)
            {
                min = strs[i].Length;
                id = i;
            }
        }
        for (int i = 0; i < min; i++)
        {
            for (int j = 0; j < strs.Length - 1; j++)
            {
                if (strs[j][i] != strs[j + 1][i]) return strs[j][..counter];
            }
            counter++;
        }
        return strs[id];
    }
}