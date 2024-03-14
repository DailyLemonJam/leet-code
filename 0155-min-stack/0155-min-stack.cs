public class MinStack
{
    private Stack<int> stack;
    private Stack<int> ascStack;

    public MinStack()
    {
        stack = new Stack<int>();
        ascStack = new Stack<int>();
    }

    public void Push(int val)
    {
        stack.Push(val);
        ascStack.Push(Math.Min(ascStack.Count != 0 ? ascStack.Peek() : val, val));
    }

    public void Pop()
    {
        stack.Pop();
        ascStack.Pop();
    }

    public int Top()
    {
        return stack.Peek();
    }

    public int GetMin()
    {
        return ascStack.Peek();
    }
}