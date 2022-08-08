Console.Write("Введите первое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num < num1)
{
    Console.WriteLine($"Наибольшее число: {num1}. Наименьшее число: {num}");
}
else {
    Console.WriteLine($"Наибольшее число: {num}. Наименьшее число: {num1}");
}