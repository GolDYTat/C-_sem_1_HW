Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ReturnSecond(int num)
{
    int num1 = num % 100;
    int num2 = num1 / 10;
    return num2;
}

if (number > 99 && number < 1000) 
{
    int res = ReturnSecond(number);
    Console.WriteLine($"Вторая цифра числа {number} ==> {res}");
}
else Console.WriteLine("Некорректный ввод, пожалуйста, введите трехзначное число");