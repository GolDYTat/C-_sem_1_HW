Console.Clear();
Console.WriteLine("Введите неотрицательное число: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());

int sum = AkkermanFunc(numberFirst, numberSecond);
Console.WriteLine($"Функция Аккермана: А({numberFirst},{numberSecond}) = {sum} ");

int AkkermanFunc(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return AkkermanFunc(m - 1, 1);
    return AkkermanFunc(m-1, AkkermanFunc(m, n - 1));
}