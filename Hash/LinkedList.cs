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
        
        // Creating a head if there is no head
        if (head == null)
        {
            head = new Node(data); 
            return;
        }
        
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

    public void deleteWithValue(int data)
    {
        if (head == null) return;
        
        // Expression if node that should be removed is head
        if (head.data == data)
        {
            head = head.next;
            return;
        }
        
        Node current = head;

        while (current.next != null)
        {
            if (current.next.data == data)
            {
                // By doing so we "remove" nsuch node by making pointer to the next value of data
                current.next = current.next.next;
                return;
            }

            current = current.next;
            
        }

        
    }
    
}