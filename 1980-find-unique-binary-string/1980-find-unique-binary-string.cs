public class Solution
{
    public string FindDifferentBinaryString(string[] nums)
    {
        int l = nums.Length;
        var sb = new StringBuilder();
        for (int i = 0; i < l; i++)
        {
            sb.Append(nums[i][i] == '0' ? '1' : '0');
        }
        return sb.ToString();
    }
}