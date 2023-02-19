namespace Hash;

public class Node
{
    public Node next;
    public int data;

    // The data itself is KeyValuePair pair
    public Node(int data)
    {
        this.data = data;
    }

}

public class LinkedList
{
    Node head;
    
    public void append(int data)
    {
        // Start from the head
        Node current = head;
        
        // Walking through linked list until next element is not null
        while (current.next != null)
        {
            current = current.next;
        }
            
        // If it is null we append our data to the end of the list
        current.next = new Node(data);
    }
}