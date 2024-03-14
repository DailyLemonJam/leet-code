public class Solution
{
    public int NumberOfBeams(string[] bank)
    {
        int result = 0;

        for (int i = 0; i < bank.Length; i++)
        {
            int curRowLength = 0;
            for (int j = 0; j < bank[i].Length; j++)
            {
                if (bank[i][j] == '1') curRowLength++;
            }

            i++;
            if (i == bank.Length) return result;

            while (!bank[i].Contains('1'))
            {
                i++;
                if (i == bank.Length) return result;
            }

            for (int j = 0; j < bank[i].Length; j++)
            {
                if (bank[i][j] == '1') result += curRowLength;
            }
            i--;
        }

        return result;
    }
}