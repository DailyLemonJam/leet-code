public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int up = 0;
        int down = matrix.Length;
        int rowToFind = (up + down) / 2;

        do
        {
            if (target >= matrix[rowToFind][0] && target <= matrix[rowToFind][^1])
            {
                int left = 0;
                int right = matrix[0].Length;
                int mid = (left + right) / 2;

                do
                {
                    if (matrix[rowToFind][mid] == target) return true;

                    if (matrix[rowToFind][mid] > target) right = mid;
                    else left = mid + 1;

                    mid = (left + right) / 2;
                } while (left < right);

                return false;
            }

            if (matrix[rowToFind][^1] > target) down = rowToFind;
            else up = rowToFind + 1;

            rowToFind = (up + down) / 2;
        } while (up < down);

        return false;
    }
}