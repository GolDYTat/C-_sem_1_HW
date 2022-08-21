Console.WriteLine("Введите размер массива: ");
int sz = Convert.ToInt32(Console.ReadLine());

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

int CountEvenNum (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int even = array[i] % 2;
        if (even == 0) count++;
        else count = count;
    }
    return count;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] arr = CreateArray(sz);
PrintArray(arr);
int cnt = CountEvenNum(arr);
Console.Write($"Колличество четных чисел в массиве - {cnt}");
