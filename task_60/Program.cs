Console.Clear();
Console.WriteLine("Введите размерность массива через пробел: ");
string[] a = Console.ReadLine().Split(" ");
int[,,] array = GetArray(new int[] { int.Parse(a[0]), int.Parse(a[1]), int.Parse(a[2]), }, 10, 99);
Console.Clear();
Console.WriteLine($"Массив размером {a[0]} x {a[1]} x {a[2]}");

int[,,] GetArray(int[] size, int min, int max)
{
    int[,,] result = new int[size[0], size[1], size[2]];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int k = 0;
            while (k < result.GetLength(2))
            {
                int element = new Random().Next(min, max + 1);
                if (FindElement(result, element)) continue;
                result[i, j, k] = element;
                k++;
            }
        }
    }
    return result;
}

bool FindElement(int[,,] array, int elem)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == elem) return true;
            }
        }
    }
    return false;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

PrintArray(array);
  