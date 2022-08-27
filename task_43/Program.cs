Console.Clear();
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Уравнение первой прямой: y = {k1}x + {b1}. Уравнение второй прямой: y = {k2}x + {b2}");

double PointOfIntersectionX (double kk1, double bb1, double kk2, double bb2)
{
    if (kk1 == kk2) Console.WriteLine("Прямые параллельны");
    return (bb2 - bb1) / (kk1 - kk2);
}

double PointOfIntersectionY (double kk1, double bb1, double kk2, double bb2)
{
    double xx = (bb2 - bb1) / (kk1 - kk2);
    double yy = kk1 * xx + bb1;
    return yy;
}

double x = PointOfIntersectionX (k1, b1, k2, b2);
double y = PointOfIntersectionY (k1, b1, k2, b2);
Console.WriteLine($"Точка пересечения двух прямых -> ({x};{y})");