public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        var q = new Queue<char>();

        for (int i = 0; i < word1.Length; i++)
        {
            for (int j = 0; j < word1[i].Length; j++)
            {
                q.Enqueue(word1[i][j]);
            }
        }

        for (int i = 0; i < word2.Length; i++)
        {
            for (int j = 0; j < word2[i].Length; j++)
            {
                if (q.Count == 0 || q.Dequeue() != word2[i][j]) return false;
            }
        }

        return q.Count == 0 ? true : false;
    }
}