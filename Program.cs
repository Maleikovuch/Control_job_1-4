string[] array = new string[7] { "yes", "no", "hello", "world", "res", "hi", "12345" };

string[] NewArrayWithElementsSizesNoMoreThreeSymbols(string[] array)
{
    int lengthArroy2 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            lengthArroy2++;
        }
    }

    string[] array2 = new string[lengthArroy2];

    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[j] = array[i];
            j++;
        }
    }
    return array2;

}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

PrintArray(array);

string[] result = NewArrayWithElementsSizesNoMoreThreeSymbols(array);
PrintArray(result);


