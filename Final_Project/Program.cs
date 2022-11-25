Console.Write("сколько элементов будет введено: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] arrayStrings = new string[size];
InsertUserElements(size);
string[] resultArray = MakeResultArray(size, arrayStrings);
PrintArray(resultArray);





void InsertUserElements(int size)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"введите {i + 1}-й элемент: ");
        string element = Convert.ToString(Console.ReadLine());
        arrayStrings[i] = element;
    }
}

string[] MakeResultArray(int size, string[] arrayStr)
{
    string[] arrayFinal = new string[size];
    int length = 3;
    int position = 0;
    for (int i = 0; i < size; i++)
    {
        if (arrayStr[i].Length <= length)
        {
            arrayFinal[position] = arrayStr[i];
            position++;
        }
    }
    return arrayFinal;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array.Length >= 3) Console.Write($"[{array[i]}], ");
        else Console.Write($"[{array[i]}]");
    }
}
