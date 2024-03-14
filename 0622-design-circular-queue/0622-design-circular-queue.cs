public class MyCircularQueue
{
    private int[] Data;
    private int InitialSize;
    private int CurrentSize = 0;

    private int HeadPtr = 0; // index
    private int TailPtr = -1; // index

    public MyCircularQueue(int k)
    {
        InitialSize = k;
        Data = new int[k];
    }

    public bool EnQueue(int value)
    {
        if (IsFull()) return false;

        TailPtr++;
        if (TailPtr == InitialSize) TailPtr = 0;

        Data[TailPtr] = value;

        CurrentSize++;
        return true;
    }

    public bool DeQueue()
    {
        if (IsEmpty()) return false;

        HeadPtr++;
        if (HeadPtr == InitialSize) HeadPtr = 0;

        CurrentSize--;
        return true;
    }

    public int Front()
    {
        return IsEmpty() ? -1 : Data[HeadPtr];
    }

    public int Rear()
    {
        return IsEmpty() ? -1 : Data[TailPtr];
    }

    public bool IsEmpty()
    {
        return CurrentSize == 0;
    }

    public bool IsFull()
    {
        return CurrentSize == InitialSize;
    }
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */