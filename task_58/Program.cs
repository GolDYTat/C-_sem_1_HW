Console.Clear();
Console.Write("Введите количество строк для первой матрицы: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для первой матрицы: ");
int c1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк для второй матрицы: ");
int r2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для второй матрицы: ");
int c2 = Convert.ToInt32(Console.ReadLine());
Console.Clear();
if (c1 != r2) Console.WriteLine("Данные матрицы перемножить невозможно.");

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

void MatrixMultiplication(int[,] martrix1, int[,] martrix2, int[,] result)
{
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < martrix1.GetLength(1); k++)
      {
        sum += martrix1[i,k] * martrix2[k,j];
      }
      result[i,j] = sum;
    }
  }
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

int[,] mtrx1 = CreateArray(r1, c1);
int[,] mtrx2 = CreateArray(r2, c2);
int[,] mtrxMain = CreateArray(r1, c2);
Console.WriteLine("Первая матрица");
PrintArray(mtrx1);
Console.WriteLine("Вторая матрица");
PrintArray(mtrx2);
Console.WriteLine("Результирующая матрица");
MatrixMultiplication(mtrx1, mtrx2, mtrxMain);
PrintArray(mtrxMain);