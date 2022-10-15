// Программа задает массив заполненный случайными положительными трёхзначными числами.
//Показывает количество четных чисел в массиве.
int enterNumber(string msg, string errorMsg)
{
    int number;
    while (true)
    {
        Console.Write(msg);
        if (int.TryParse(Console.ReadLine(), out number))
        {
            return number;
        }
        Console.WriteLine(errorMsg);
    }
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }

    return res;
}

int CountEven(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0) count += 1;
    }
    return count;
}

Console.Clear();

int Size = enterNumber("Введите количество элементов массива:  ", "Введите целое число");
int[] array = GetArray(Size, 100, 999);
Console.WriteLine($"[{String.Join(", ", array)}] -> {CountEven(array)}");