//Программа задает одномерный массив, заполненный случайными числами.
//Находит сумму элементов на нечетных позмцмях.
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

int GetSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

Console.Clear();

int Size = enterNumber("Введите количество элементов массива:  ", "Введите целое число");
Console.WriteLine("Введите диапазон чисел для заполнения массива");
int minValue = enterNumber("Введите нижнее число диапазона:  ", "Введите целое число");
int maxValue = enterNumber("Введите верхнее число диапазона:  ", "Введите целое число");
int[] array = GetArray(Size, minValue, maxValue);
Console.WriteLine($"[{String.Join(", ", array)}] -> {GetSum(array)}");