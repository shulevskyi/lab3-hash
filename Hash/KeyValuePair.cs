namespace Hash;

public class KeyValuePair
{
    public int Key { get; set; }

    public string Value { get; set; }

    public KeyValuePair(int key, string value)
    {
        Key = key;
        Value = value;
    }
}

//KeyValuePair word1 = new KeyValuePair(1, "Automachine");