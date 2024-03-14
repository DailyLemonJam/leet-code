public class Solution
{
    public int NumSpecial(int[][] mat)
    {
        int result = 0;

        for (int row = 0; row < mat.Length; row++)
        {
            for (int column = 0; column < mat[row].Length; column++)
            {
                if (mat[row][column] == 1)
                {
                    bool jColumnHasOnes = false;
                    bool iRowHasOnes = false;

                    for (int jColumn = 0; jColumn < mat[row].Length; jColumn++)
                    {
                        if (jColumn != column && mat[row][jColumn] == 1)
                        {
                            jColumnHasOnes = true;
                            break;
                        }
                    }

                    if (!jColumnHasOnes)
                    {
                        for (int iRow = 0; iRow < mat.Length; iRow++)
                        {
                            if (iRow != row && mat[iRow][column] == 1)
                            {
                                iRowHasOnes = true;
                                break;
                            }
                        }
                    }
                    
                    if (!jColumnHasOnes && !iRowHasOnes) result++;
                }
            }
        }

        return result;
    }
}