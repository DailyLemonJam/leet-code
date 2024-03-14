public class Solution
{
    public int ClimbStairs(int n)
    {
        int f1 = 1;
        int f2 = 1;

        for (int i = 0; i < n - 1; i++)
        {
            (f1, f2) = (f1 + f2, f1);
        }

        return f1;
    }
}