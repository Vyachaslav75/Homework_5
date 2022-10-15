//Программа задает массив вещественных чисел.
//Находит разницу между максимальным и минимальным элементами.
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

double[] GetArrayDouble(int size, int rank)
{
    double[] res = new double[size];
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = GetDoubleRandom(rank);
    }

    return res;
}

double GetDoubleRandom(int usRank)
{
    double myDouble = new Random().NextDouble();
    int rank = new Random().Next(0, usRank + 1);
    myDouble = myDouble * Math.Pow(10, rank);
    return myDouble;
}

double MinElt(double[] array)
{
    double minEl = array[0];
    foreach (double item in array)
    {
        if (item < minEl) minEl = item;
    }
    return minEl;
}
double MaxElt(double[] array)
{
    double maxEl = array[0];
    foreach (double item in array)
    {
        if (item > maxEl) maxEl = item;
    }
    return maxEl;
}

Console.Clear();

int Size = enterNumber("Введите количество элементов массива:  ", "Введите целое число");
int myRank = enterNumber("Введите максимальный порядок числа:  ", "Введите целое число");
double[] array = GetArrayDouble(Size, myRank);
Console.WriteLine($"[{String.Join(", ", array)}] -> {MaxElt(array) - MinElt(array)}");