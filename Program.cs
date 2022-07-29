string[] CreateAndFillStringArray(int size)
{
    string[] elements = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i +1} word: ");
        elements[i] = Console.ReadLine();
    }

    return elements;
}

string PrintArray(string[] array)
{
    string showArray = String.Empty;
    for (int i = 0; i < array.Length; i++)
        showArray += array[i] + " ";
    return showArray;
}

string[] myArray = CreateAndFillStringArray(5);

Console.WriteLine(PrintArray(myArray));
