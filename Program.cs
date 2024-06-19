using System.Collections;

public class App
{
    static void Main()
    {
        Stack theStack = new Stack();
        foreach (var item in theStack)
        {
            Console.WriteLine(item.ToString());
        }
    }
}

public class Stack : IEnumerable
{
    private Random gen;
    public Stack()
    {
        gen = new Random();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return (IEnumerator)GetEnumerator();
    }

    public StackEnum GetEnumerator()
    {
        return new StackEnum(gen);
    }
}

public class StackEnum : IEnumerator
{
    public Random rand;
    int position = -1;

    public StackEnum(Random random)
    {
        rand = random;
    }

    public int Current
    {
        get
        {
            return rand.Next();
        }
    }

    public bool MoveNext()
    {
        position++;
        return true;
    }

    public void Reset()
    {
        position = -1;
    }

    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }
}