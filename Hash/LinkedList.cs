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
