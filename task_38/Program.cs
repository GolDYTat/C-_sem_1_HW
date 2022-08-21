Console.Clear();
Console.WriteLine("Введите размер массива: ");
int sz = Convert.ToInt32(Console.ReadLine());

double[] CreateArray(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble() * (100 - 1) + 1;
    }
    return array;
}

double DiffMaxMin (double[] array)
{
    double difference = 0;
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else max = max;
        if (array[i] < min) min = array[i];
        else min = min;
        difference = max - min;
    }
    return difference;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{Math.Round(array[i], 2)}; ");
        else Console.Write($"{Math.Round(array[i], 2)}");
    }
    Console.WriteLine("]");
}

double[] arr = CreateArray(sz);
PrintArray(arr);
double diff = DiffMaxMin(arr);
Console.Write($"Разница между максимальным и минимальным элементом массива = {Math.Round(diff, 2)}");


