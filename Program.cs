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



string[] ResultArray(string[] array, int symbAmount)
{
    int CountElements(string[] array)
    {
        int count = 0;

        for (int i = 0; i < array.Length; i++)
            if(array[i].Length <= symbAmount)
                count++;

        return count;
    }
    
    string[] resultArray = new string[CountElements(array)];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= symbAmount)
        {
            resultArray[index] = array[i];
            index += 1;
        }
                    
    }
    return resultArray;
}


string[] myArray = CreateAndFillStringArray(5);
Console.WriteLine(PrintArray(myArray));


int amount = 3;
Console.WriteLine(PrintArray(ResultArray(myArray, amount)));