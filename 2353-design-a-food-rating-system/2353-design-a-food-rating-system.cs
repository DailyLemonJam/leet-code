public class FoodRatings
{
    private Dictionary<string, Dictionary<string, int>> Map; // cuisine - name, rating

    public FoodRatings(string[] foods, string[] cuisines, int[] ratings)
    {
        Map = new Dictionary<string, Dictionary<string, int>>();

        for (int i = 0; i < foods.Length; i++)
        {
            if (!Map.TryAdd(cuisines[i], new Dictionary<string, int>() { { foods[i], ratings[i] } }))
            {
                Map[cuisines[i]].Add(foods[i], ratings[i]);
            }
        }
    }

    public void ChangeRating(string food, int newRating)
    {
        foreach (var item in Map)
        {
            if (item.Value.ContainsKey(food))
            {
                item.Value[food] = newRating;
                break;
            }
        }
    }

    public string HighestRated(string cuisine)
    {
        string bestFood = string.Empty;
        int curMaxRating = int.MinValue;

        foreach (var food in Map[cuisine])
        {
            if (food.Value > curMaxRating)
            {
                curMaxRating = food.Value;
                bestFood = food.Key;
            }
            else if (food.Value == curMaxRating)
            {
                if (string.Compare(food.Key, bestFood) < 0)
                {
                    bestFood = food.Key;
                }
            }
        }

        return bestFood;
    }
}

/**
 * Your FoodRatings object will be instantiated and called as such:
 * FoodRatings obj = new FoodRatings(foods, cuisines, ratings);
 * obj.ChangeRating(food,newRating);
 * string param_2 = obj.HighestRated(cuisine);
 */
