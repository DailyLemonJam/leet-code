public class Solution
{
    public string[] FindRestaurant(string[] list1, string[] list2)
    {
        int curMin = int.MaxValue;
        var res = new List<string>();

        for (int i = 0; i < list1.Length; i++)
        {
            if (list2.Contains(list1[i]))
            {
                if (i + list2.ToList().IndexOf(list1[i]) < curMin)
                {
                    curMin = i + list2.ToList().IndexOf(list1[i]);
                    res.Clear();
                    res.Add(list1[i]);
                }
                else if (i + list2.ToList().IndexOf(list1[i]) == curMin)
                {
                    res.Add(list1[i]);
                }
            }
        }

        return res.ToArray();
    }
}