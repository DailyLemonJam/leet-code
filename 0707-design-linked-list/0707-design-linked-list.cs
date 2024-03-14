public class MyLinkedList
{
    private class Node
    {
        public int Val { get; set; }
        public Node Next { get; set; }

        public Node(int val)
        {
            Val = val;
        }
    }

    private Node? Head;
    private int TotalCount = 0;

    public MyLinkedList()
    {
        Head = null;
    }

    private Node GetNodeAtIndex(int index)
    {
        if (index >= TotalCount) return null;

        var node = Head;

        for (int i = 0; i < index; i++)
        {
            node = node.Next;
        }

        return node;
    }

    public int Get(int index)
    {
        var node = GetNodeAtIndex(index);

        return node == null ? -1 : node.Val;
    }

    public void AddAtHead(int val)
    {
        var newHead = new Node(val) 
        { 
            Next = Head 
        };

        Head = newHead;

        TotalCount++;
    }

    public void AddAtTail(int val)
    {
        if (Head == null)
        {
            AddAtHead(val);
            return;
        }

        var node = GetNodeAtIndex(TotalCount - 1);
        node.Next = new Node(val);

        TotalCount++;
    }

    public void AddAtIndex(int index, int val)
    {
        if (index > TotalCount) return;

        if (index == 0)
        {
            AddAtHead(val);
            return;
        }

        var prev = GetNodeAtIndex(index - 1);

        var newNode = new Node(val)
        {
            Next = prev.Next
        };

        prev.Next = newNode;

        TotalCount++;
    }

    public void DeleteAtIndex(int index)
    {
        if (TotalCount == 0) return;

        if (index < TotalCount && index >= 0)
        {
            if (index == 0) Head = Head.Next;
            else
            {
                var node = GetNodeAtIndex(index - 1);
                node.Next = node.Next.Next;
            }

            TotalCount--;
        }
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */