Console.Clear();
Console.WriteLine("Введите количество строк: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int c = Convert.ToInt32(Console.ReadLine());

double[,] CreateMatrix(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * 20;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{Math.Round(matrix[i, j], 1), 6},");
            else Console.Write($"{Math.Round(matrix[i, j], 1), 6}");
        }
        Console.WriteLine("]");
    }
}

double[,] newMatrix = CreateMatrix(3, 4);
PrintMatrix(newMatrix);