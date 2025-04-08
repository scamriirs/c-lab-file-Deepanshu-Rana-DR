using System;

class Sample
{
    private string[] names = new string[10];
    private int[] ids = new int[10];

    // Indexer by integer
    public string this[int index]
    {
        get { return names[index]; }
        set { names[index] = value; }
    }

    // Indexer by string
    public int this[string name]
    {
        get
        {
            for (int i = 0; i < names.Length; i++)
                if (names[i] == name)
                    return ids[i];
            return -1;
        }
        set
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    ids[i] = value;
                    return;
                }
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Sample sample = new Sample();

        sample[0] = "Alice";
        sample[1] = "Bob";

        sample["Alice"] = 1001;
        sample["Bob"] = 1002;

        Console.WriteLine("ID of Alice: " + sample["Alice"]);
        Console.WriteLine("ID of Bob: " + sample["Bob"]);
    }
}
