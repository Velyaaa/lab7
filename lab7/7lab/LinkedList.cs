class LinkedList
{
    class Node
    {
        public double Value;
        public Node? Next;

        public Node(double value)
        {
            Value = value;
            Next = null;
        }
    }
    private Node? head;
    private int count = 0;

    public LinkedList()
    {
        head = null;
    }

    public void PrintList()
    {
        Node? current = head;
        while (current != null)
        {
            Console.Write(current.Value + " -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }

    public void AddFirst(double value)
    {
        Node newNode = new Node(value);
        newNode.Next = head;
        head = newNode;
        count++;
    }

    public void RemoveByIndex(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (index == 0)
        {
            head = head?.Next;
        }
        else
        {
            Node? current = head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current!.Next;
            }

            current!.Next = current.Next?.Next;
        }
        count--;
    }

    public double CalculateSum()
    {
        double sum = 0.0;
        Node? current = head;
        while (current != null)
        {
            sum += current.Value;
            current = current.Next;
        }
        return sum;
    }

    public double CalculateAverage()
    {
        return CalculateSum() / Count;
    }

    public double? FindFirstGreaterElement()
    {
        double average = CalculateAverage();

        Node? current = head;
        while (current != null)
        {
            if (current.Value > average)
            {
                return current.Value;
            }
            current = current.Next;
        }

        return null;
    }

    public double FindSumOfGreaterElements(double key)
    {
        double sum = 0.0;
        Node? current = head;
        while (current != null)
        {
            if (current.Value > key)
            {
                sum += current.Value;
            }
            current = current.Next;
        }

        return sum;
    }

    public LinkedList FindElementsSmallerThanAverage()
    {
        LinkedList newList = new LinkedList();
        double average = CalculateAverage();

        Node? current = head;
        while (current != null)
        {
            if (current.Value < average)
            {
                newList.AddFirst(current.Value);
            }
            current = current.Next;
        }

        return newList;
    }

    public void RemoveElementsAtEvenIndices()
    {
        for (int i = Count - 1; i >= 0; i--)
        {
            if (i % 2 == 0)
            {
                RemoveByIndex(i);
            }
        }
    }

    public double this[int index]
    {
        get
        {
            if (index < 0 || index >= count)
                throw new ArgumentOutOfRangeException(nameof(index));

            Node current = head!;
            for (int i = 0; i < index; i++)
            {
                current = current.Next!;
            }

            return current.Value;
        }
        set
        {
            if (index < 0 || index >= count)
                throw new ArgumentOutOfRangeException(nameof(index));

            Node current = head!;
            for (int i = 0; i < index; i++)
            {
                current = current.Next!;
            }

            current.Value = value;
        }
    }

    public int Count => count;
}
