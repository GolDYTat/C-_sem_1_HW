Console.Clear();
Console.Write("Введите количество строк: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int c = Convert.ToInt32(Console.ReadLine());

int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

double[] AverageColumns(int[,] array)
{
    double[] count = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            count[i] += array[j, i];
        }
    }
    Console.Write("Среднее арифметическое каждого столбца -> [");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        if (i < array.GetLength(1) - 1) Console.Write($"{Math.Round(count[i] / r, 2), 3}, ");
        else Console.Write($"{Math.Round(count[i] / r, 2), 3}");
    }
    Console.Write(" ]");
    return count;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3},");
            else Console.Write($"{array[i, j],3}");
        }
        Console.WriteLine(" ]");
    }
}

int[,] arr = CreateArray(r, c);
PrintArray(arr);
AverageColumns(arr);
