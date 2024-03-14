public class Solution
{
    public int[] AsteroidCollision(int[] asteroids)
    {
        var stack = new Stack<int>();

        for (int i = 0; i < asteroids.Length; i++)
        {
            if (stack.Count == 0 || (stack.Peek() < 0 == asteroids[i] < 0)) stack.Push(asteroids[i]);
            else
            {
                if (asteroids[i] > 0) stack.Push(asteroids[i]);
                else if (stack.Peek() == Math.Abs(asteroids[i])) stack.Pop();
                else
                {
                    while (true)
                    {
                        if (stack.Peek() < 0)
                        {
                            stack.Push(asteroids[i]);
                            break;
                        }

                        if (stack.Peek() > Math.Abs(asteroids[i])) 
                            break;
                        else if (stack.Peek() == Math.Abs(asteroids[i]))
                        {
                            stack.Pop();
                            break;
                        }
                        else
                        {
                            stack.Pop();
                            if (stack.Count == 0)
                            {
                                stack.Push(asteroids[i]);
                                break;
                            }
                        }
                    }
                }
            }
        }

        return stack.Reverse().ToArray();
    }
}