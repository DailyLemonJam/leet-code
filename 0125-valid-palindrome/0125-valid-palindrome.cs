public class Solution
{
    public bool IsPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            char leftChar = char.ToLower(s[left]);
            char rightChar = char.ToLower(s[right]);

            if (!char.IsLetter(leftChar) && !char.IsDigit(leftChar)) left++;
            else if (!char.IsLetter(rightChar) && !char.IsDigit(rightChar)) right--;
            else
            {
                if (leftChar != rightChar) return false;
                left++;
                right--;
            }
        }

        return true;
    }
}