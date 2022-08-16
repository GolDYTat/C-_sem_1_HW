Console.Clear();
Console.WriteLine("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1) Console.WriteLine("Введите положительное число");

void TableCube (int num)
{
    for (int i = 1; i <= num; i++)
    Console.WriteLine($"{i}  {i*i*i}");
}

TableCube(number);
