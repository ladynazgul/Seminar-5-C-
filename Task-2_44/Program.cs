//  Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

Console.WriteLine("Введите k1");
double k1 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите b1");
double b1 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите k2");
double k2 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите b2");
double b2 = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Две прямые пересекутся в точке с одинаковыми координатами, поэтому правые части уравнений нужно приравнять");
Console.WriteLine($"{k1}x + {b1} = {k2}x + {b2}");

if (k1 == k2 && b1 == b2)
    Console.WriteLine(" Прямые совпадают ");
  
else if (k1 == k2 || b1 == b2)
    Console.WriteLine(" Точки пересечения нет ");

else
{
    double x = (b2 - b1)/(k1 - k2);
    double y = k1*x + b1;
    Console.Write($"координаты точки пересечения: ({x}, {y})");
}
