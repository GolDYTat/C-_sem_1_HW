Console.Clear();
Console.WriteLine("Введите целые числа через пробел: ");
string a = (Console.ReadLine());

int[] ConvertStringToInt (string n)
{
    string[] stringArr = n.Split(' ');
    int[] intArr = new int [stringArr.Length];
    for (int i = 0; i < stringArr.Length; i++)
    {
        intArr[i] = Convert.ToInt32(stringArr[i]);
    }
    return intArr;
}

int CountPositiveNumbers (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int[] intArray = ConvertStringToInt(a);
int result = CountPositiveNumbers(intArray);
Console.WriteLine($"Количество чисел, которые больше 0: {result}");
