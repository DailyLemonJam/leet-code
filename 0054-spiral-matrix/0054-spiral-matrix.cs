public class Solution
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        var result = new List<int>();

        int totalCount = matrix.Length * matrix[0].Length;
        int counter = 0;

        int green = 0, blue = 0;
        int orange = matrix[0].Length - 1, red = matrix.Length - 1;

        while (true)
        {
            for (int x = green; x <= orange; x++)
            {   
                result.Add(matrix[blue][x]);
                counter++;
            }
            blue++;
            if (counter == totalCount) return result;
            
            for (int y = blue; y <= red; y++)
            {
                result.Add(matrix[y][orange]);
                counter++;
            }
            orange--;

            for (int x = orange; x >= green; x--)
            {
                result.Add(matrix[red][x]);
                counter++;
            }
            red--;
            if (counter == totalCount) return result;

            for (int y = red; y >= blue; y--)
            {
                result.Add(matrix[y][green]);
                counter++;
            }
            green++;
        }
    }
}