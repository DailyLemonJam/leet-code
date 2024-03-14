using System.Globalization;

public class Solution
{
    public string LargestGoodInteger(string num)
    {
        string max = "-1";

        for (int i = 0; i < num.Length - 2; i++)
        {
            if (num[i] == num[i + 1] && num[i] == num[i + 2])
            {
                if (int.Parse(num.Substring(i, 3)) > int.Parse(max.ToString()))
                {
                    max = num.Substring(i, 3);
                }
            }
        }
        
        return max == "-1" ? "" : max;
    }
}