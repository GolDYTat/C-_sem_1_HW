Console.Clear();
Console.WriteLine("Введите два числа: ");
Console.Write("Первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число: ");
int y = Convert.ToInt32(Console.ReadLine());

int Multipl(int a, int b)
{
    int res = 1;
    for (int i = 0; i < b; i++)
    {
        res = res * a;
    }
    return res;
}

int result = Multipl(x, y);
Console.WriteLine($"{x} в степени {y} = {result}");