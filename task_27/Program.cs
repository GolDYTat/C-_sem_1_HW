Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Count(int numb)
{
    int cnt = 0;
    while (numb > 0)
    {
        numb = numb / 10;
        cnt++;
    }
    return cnt;
}

int count = Count(number);
Console.WriteLine($"{count}");

int SumDigit(int num)
{
    int res = 0;
    for (int i = 0; i < count; i++)
    {
        res = res + num % 10;
        num = num / 10;
    }
    return res;
}

int result = SumDigit(number);
Console.WriteLine($"Сумма цифр числа {number} = {result}");