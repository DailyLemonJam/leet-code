public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        if (ransomNote.Length > magazine.Length) return false;

        var dictionary = new Dictionary<char, int>();
        for (int i = 0; i < ransomNote.Length; i++)
        {
            if (!dictionary.ContainsKey(ransomNote[i]))
            {
                dictionary.Add(ransomNote[i], 1);
            }
            else
            {
                dictionary[ransomNote[i]]++;
            }
        }

        for (int i = 0; i < magazine.Length; i++)
        {
            if (dictionary.ContainsKey(magazine[i]))
            {
                dictionary[magazine[i]]--;
            }
        }

        foreach(char c in dictionary.Keys)
        {
            if (dictionary[c] > 0) return false;
        }

        return true;
    }
}