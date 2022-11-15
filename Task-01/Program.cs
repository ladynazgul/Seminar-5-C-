// Выяснить, являются ли 3 числа сторонами треугольника

// int GetNumber()
// {
//     Console.WriteLine("Введите число: ");
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     return number;
// }
// int A = GetNumber();
// int B = GetNumber();
// int C = GetNumber();

// if(A + B > C && B + C > A && A + C > B)
// {
//     Console.WriteLine("Данные числа являются сторонами треугольника");
// }
// else
// Console.WriteLine("Данные числа не являются сторонами треугольника");


// Способ решения через bool
Console.Clear();
System.Console.WriteLine();

int A = 12;
int B = 25;
int C = 12;

bool triangle = (A + B > C && A + C > B && B + C > A);

if (triangle) System.Console.WriteLine("Из заданных отрезков можно составить треугольник");
else System.Console.WriteLine("Из заданных отрезков составить треугольник невозможно");