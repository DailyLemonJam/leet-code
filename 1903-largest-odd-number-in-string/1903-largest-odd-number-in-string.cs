public class Solution {
    public string LargestOddNumber(string num) {
        for (int i = num.Length - 1; i > -1 ; i--)
        {
            if ((num[i] - '0') % 2 == 1) return num[..(i + 1)];
        }
        return "";
    }
}