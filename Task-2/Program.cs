/*----------------------------------------------------------------------------------------------------------------------
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
----------------------------------------------------------------------------------------------------------------------*/

double Dist(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double dx = x2-x1;
    double dy = y2-y1;
    double dz = z2-z1;
    return Math.Sqrt(dx*dx+dy*dy+dz*dz);
}

Console.Write("Введите координату х первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z первой точки: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату х второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z второй точки: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Расстояние между точками ({x1},{y1},{z1}) и ({x2},{y2},{z2}) : {Dist(x1,y1,z1,x2,y2,z2):F2}");
