Console.Clear();
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SearchPal(int num)
{
    int res = 0;
    while (num >= 10000 && num <= 99999)
    {
        int n1 = num / 10000;
        int n5 = num % 10;
        int n2 = num / 1000;
        int n4 = num % 100;
        if (n1 == n5 && n2 % 10 == n4 / 10) return res = 1;
        else return res = 2;
    }
    return res = -1;
}

int result = SearchPal(number);
if (result == 1) Console.WriteLine($"Число {number} является палиндромом");
else if (result == -1) Console.WriteLine($"Число {number} не является пятизначным");
else if (result == 2) Console.WriteLine($"Число {number} не является палиндромом");
