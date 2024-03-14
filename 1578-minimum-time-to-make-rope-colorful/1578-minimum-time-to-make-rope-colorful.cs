public class Solution
{
    public int MinCost(string colors, int[] neededTime)
    {
        int result = 0;
        int left = 0;

        for (int i = 1; i < colors.Length; i++)
        {
            if (colors[left] == colors[i])
            {
                if (neededTime[left] < neededTime[i])
                {
                    result += neededTime[left];
                    left = i;
                }
                else result += neededTime[i];
            }
            else left = i;
        }

        return result;
    }
}