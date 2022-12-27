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

string[] array = FillArray(n);
Console.WriteLine($"Получившийся массив: [{string.Join(" , ", array)}]");
string[] array2 = Array.FindAll(array, s => s.Length < 4);
Console.WriteLine($"Получившийся массив: [{string.Join(" , ", array2)}]");