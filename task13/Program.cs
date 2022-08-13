Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ReturnThird(int num)
{
    int result = 0;
    while (num >= 1000) 
    {
        num = num / 10;
    }
    if (num < 100) return -1;
    return result = num % 10;
}

int res = ReturnThird(number);

if (res != -1) Console.WriteLine($"Третья цифра числа: {res}");
else Console.WriteLine($"Третьей цифры нет");
