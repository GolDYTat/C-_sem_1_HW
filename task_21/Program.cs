Console.Clear();
Console.WriteLine("Введите координаты для первой точки: ");
Console.Write("X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты для второй точки: ");
Console.Write("X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(int xa, int ya, int za, int xb, int yb, int zb)
{
    int sx = xb - xa;
    int sy = yb - ya;
    int sz = zb - za;
    return Math.Sqrt(sx*sx + sy*sy + sz*sz);
}

double res = Distance(x1,y1,z1,x2,y2,z2);
Console.WriteLine($"A:({x1},{y1},{z1}); B:({x2},{y2},{z2}). Расстояние между точками: {Math.Round(res, 2)})");