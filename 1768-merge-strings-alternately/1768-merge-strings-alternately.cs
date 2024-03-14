public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var sb = new StringBuilder();
        int n1 = 0;
        int n2 = 0;
        while (!(n1 > word1.Length && n2 > word2.Length))
        {
            if (n1 < word1.Length) sb.Append(word1[n1]);
            if (n2 < word2.Length) sb.Append(word2[n2]);
            n1++;
            n2++;
        }
        return sb.ToString();
    }
}