Console.WriteLine("Введите количество строк:");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = new string[size];
for (int i = 0; i < size; i++)
{
    Console.Write("Введите строку №{0}:\r\n    ", i + 1);
    array[i] = Console.ReadLine()!;
}
Console.Write("Нажмите [Enter] для вывода вашего массива и созданного из него массива, у которого длина всех элементов >=3");
Console.ReadLine();


// string[] array = { "yes", "no", "hello", "world", "res", "hi", "12345" };

string[] NewArrayWithElementsSizesNoMoreThreeSymbols(string[] array)
{
    int lengthNewArroy = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            lengthNewArroy++;
        }
    }

    string[] newArray = new string[lengthNewArroy];

    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;

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


