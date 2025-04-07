class Program
{
    static void Main()
    {
        LinkedList list = new LinkedList();

        list.AddFirst(1110.22);
        list.AddFirst(3.57);
        list.AddFirst(-964.25);
        list.AddFirst(-73.23);
        list.AddFirst(-2.82);
        list.AddFirst(143.84);
        list.AddFirst(4.96);
        list.AddFirst(-77.96);

        Console.WriteLine("\n<------------------------------------------------------>");
        Console.WriteLine("Створений список:");
        list.PrintList();

        Console.WriteLine($"\n1. Перший елемент більший за середнє значення ({list.CalculateAverage():F2}): {list.FindFirstGreaterElement()}");

        Console.WriteLine($"\nСума всіх елементів: {list.CalculateSum():F2}");

        Console.WriteLine($"\n2. Сума елементів, значення яких більше за задане значення ({59}): {list.FindSumOfGreaterElements(59)}:F2");

        LinkedList newList = list.FindElementsSmallerThanAverage();
        Console.WriteLine($"\n3. Новий список з елементів, що менші за середнє ({list.CalculateAverage():F2}):");
        newList.PrintList();


        Console.WriteLine($"\n4. Список після видалення елементів з парними індексами:");
        list.RemoveElementsAtEvenIndices();
        list.PrintList();

        Console.WriteLine();
        list.PrintList();
        
        try
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"Елемент з індексом {i}: {list[i]}");
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Помилка: індекс поза межами списку!");
        }

        int index = 2;

        try
        {
            list.RemoveByIndex(index);
            Console.WriteLine($"\n\nСписок після видалення елемента з індексом: {index}:");
            list.PrintList();
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Помилка: індекс поза межами списку!");
        }
    }
}

