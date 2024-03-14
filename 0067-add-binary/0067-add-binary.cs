using System.Text;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        var result = new StringBuilder();
        int savedValue = 0;

        if (a.Length != b.Length)
        {
            string temp;
            if (a.Length > b.Length)
            {
                temp = new string('0', a.Length - b.Length);
                b = temp + b;
            }
            else
            {
                temp = new string('0', b.Length - a.Length);
                a = temp + a;
            }
        }

        for (int i = a.Length - 1; i >= 0; i--)
        {
            if (a[i] == b[i])
            {
                if (a[i] == '1') // 1 1
                {
                    if (savedValue == 0) result.Append('0');
                    else result.Append('1');
                    savedValue = 1;
                }
                else // 0 0
                {
                    if (savedValue == 0) result.Append('0');
                    else
                    {
                        result.Append('1');
                        savedValue = 0;
                    }
                }
            }
            else // 0 1, 1 0
            {
                if (savedValue == 0) result.Append('1');
                else
                {
                    result.Append('0');
                    savedValue = 1;
                }
            }
        }

        if (savedValue == 1) result.Append('1');

        return new string(result.ToString().Reverse().ToArray());
    }
}