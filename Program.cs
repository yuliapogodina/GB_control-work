Console.Clear();

Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] FillArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите элемент массива {i + 1}: ");
        array[i] = Convert.ToString(Console.ReadLine() ?? "");
    }
    return array;
}

string[] SelectArrayElements(string[] inputArray, int size)
{
    string[] outArray = new string[size];
    int j = 0;
    for (int i = 0; i < size; i++)
    {
        if (inputArray[i].Length < 4)
        {
            outArray[j] = inputArray[i];
            j++;
        }
    }
    string[] outArray1 = new string[j];
    Array.Copy(outArray, 0, outArray1, 0, j);

    return outArray1;
}
string[] array = FillArray(n);
Console.WriteLine($"Получившийся массив: [{string.Join(" , ", array)}]");
string[] array2 = SelectArrayElements(array, n);
Console.WriteLine($"Получившийся массив: [{string.Join(" , ", array2)}]");