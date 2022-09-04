Console.Clear();
Console.WriteLine("Введите первое число: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());

int sum = SumNaturalElem(numberFirst, numberSecond);
Console.WriteLine($"Сумма натуральных чисел от {numberFirst} до {numberSecond} = {sum} ");

int SumNaturalElem(int m, int n)
{
    if (n < m) return n += SumNaturalElem(m, n + 1);
    else if (n > m) return m += SumNaturalElem(m + 1, n);
    else return m;
}


