Console.Clear();
Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumber(int num)
{
    if (num < 1) return;
    Console.Write($"{num} ");
    NaturalNumber(num - 1);    
}

NaturalNumber(number);