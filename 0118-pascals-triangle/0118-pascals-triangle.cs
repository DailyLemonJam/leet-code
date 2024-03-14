public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        if (numRows == 1) return new List<IList<int>>() { new List<int>() { 1 } };

        var result = new List<IList<int>>
        {
            new List<int>() { 1 },
            new List<int>() { 1, 1 }
        };

        var temp = new List<int>();

        for (int row = 2; row < numRows; row++)
        {
            temp.Add(1);
            for (int i = 1; i < row; i++)
            {
                temp.Add(result.Last()[i - 1] + result.Last()[i]);
            }
            temp.Add(1);

            result.Add(new List<int>(temp));
            temp.Clear();
        }

        return result;
    }
}