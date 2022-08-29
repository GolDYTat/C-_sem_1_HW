Console.Clear();
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер строки: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int c = Convert.ToInt32(Console.ReadLine());

if (r < 1 || r > m || c < 1 || c > n)
{
    Console.WriteLine("Такого элеменета нет");
    return;
}

int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 100);
        }
    }
    return array;
}

int SearchElem(int[,] array, int row, int column)
{
    int number = array[row - 1, column - 1];
    return number;
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

int[,] arr = CreateArray(m, n);
PrintArray(arr);
int res = SearchElem(arr, r, c);
Console.WriteLine($"Заданный элемент массива -> {res}");
