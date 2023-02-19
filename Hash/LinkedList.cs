namespace Hash;

public class LinkedListNode
{
    public KeyValuePair<int, string> Pair { get; }
        
    public LinkedListNode Next { get; set; }

    public LinkedListNode(int key, string value, LinkedListNode next = null)
    {
        Pair = new KeyValuePair<int, string>(key, value);
        Next = next;
    }
}

public class LinkedList
{
    LinkedListNode head;
    
    public void Append(int key, string value)
    {
        if (head == null)
        {
            head = new LinkedListNode(key, value);
            return;
        }
        
        LinkedListNode current = head;
        
        while (current.Next != null)
        {
            current = current.Next;
        }
            
        current.Next = new LinkedListNode(key, value);
    }

    public void Delete(int key)
    {
        if (head == null) return;
        
        if (head.Pair.Key == key)
        {
            head = head.Next;
            return;
        }
        
        LinkedListNode current = head;

        while (current.Next != null)
        {
            if (current.Next.Pair.Key == key)
            {
                current.Next = current.Next.Next;
                return;
            }

            current = current.Next;
        }
    }
}