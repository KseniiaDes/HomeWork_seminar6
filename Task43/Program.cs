// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Для нахождения точки пересечения двух прямых введите значения: ");
Console.WriteLine("Для первого уравнения вида y = k1 * x + b1: ");
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Для второго уравнения вида y = k2 * x + b2: ");
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());


double FindX (double a, double c, double b, double d)
{
    double x = (d - c) / (a - b);
    return x;
}

double FindY (double a, double c, double x)
{
    double y = a * x + c;
    return y;
}

if (k1 == k2 && b1 != b2) Console.WriteLine("Прямые параллельны");
else if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают (множество точек пересечения)");
else
{
    double findX = FindX(k1, b1, k2, b2);
    double findY = FindY(k1, b1, findX);
    Console.WriteLine($"Прямые пересекаются в точке ({findX}, {findY})");
}
