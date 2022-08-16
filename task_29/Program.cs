Console.Clear();
Console.WriteLine("Введите размер массива: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0) Console.WriteLine("Введите положительное число");

int[] Array(int size)
{
    int[] arr = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(1, 100);
    }
    return arr;
}

int[] result = Array(number - 1);

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write($"{arr[arr.Length - 1]}]");
}
PrintArray(result);
