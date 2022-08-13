Console.Write("Введите число от 1 до 7, соответствующее дню недели: ");
int number = Convert.ToInt32(Console.ReadLine());

int DayWeek(int num)
{
    int result = 0;
    if (num < 6 && num > 0) return result = result - 1;
    else if (num > 5 && num < 8) return result = result + 1;
    return result;
}

int res = DayWeek(number);
if (res == 1) Console.Write(" -> Да");
else if (res == -1) Console.Write(" -> Нет");
else Console.Write("Введите корректное число");
