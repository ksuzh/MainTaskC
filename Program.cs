string[] CreateStringAndFillArray(int size)
{
    string[] elements = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i +1} word: ");
        elements[i] = Console.ReadLine();
    }

    return elements;
}

