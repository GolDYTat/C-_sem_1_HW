Console.Clear();
Console.WriteLine("Введите размер массива: ");
int sz = Convert.ToInt32(Console.ReadLine());

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}

int SumNum (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int even = i % 2;
        if (even == 0) sum = sum;
        else sum += array[i];
    }
    return sum;
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
int sum = SumNum(arr);
Console.Write($"Сумма элементов, стоящих на нечетных индексах = {sum}");

