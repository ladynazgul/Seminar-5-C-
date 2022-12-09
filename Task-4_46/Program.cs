// 46. Написать программу масштабирования фигуры
// Масштабирование равностороннего четырехугольника (Левый нижний угол (точка А) остается на месте)

int[,] ScaleCoords(int[] a, int[] b, int[] c, int[] d, int k) // метод для пересчитывания координат, для всех точек, кроме a
{
    int[,] coord = new int[4, 2];                              // для вывода всех координат записываем их в двумерный массив
    for (int ii = 0; ii < 2; ii++)                             // индекс массива - координаты точки
    {
        for (int j = 0; j < 2; j++)                            // индекс столбцов, индексы строк задаем ниже вручную
        {
            if (ii == j)                                       // индекс столбца равен индексу координаты точки
            {
                coord[0, j] = a[ii];                           // здесь задаем новые координаты с поправкой на неподвижную точку a
                coord[1, j] = (b[ii] - a[ii]) * k + a[ii];
                coord[2, j] = (c[ii] - a[ii]) * k + a[ii];
                coord[3, j] = (d[ii] - a[ii]) * k + a[ii]; 
            }
        }
    }
    return coord;
}

void PrintCoords(int[,] arr, char[] point)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"{point[i]} ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"({arr[i, j]}, ");
            else Console.WriteLine($"{arr[i, j]})");
        }
    }
}

int k = 2;
int[] pointA = { 3, 2 };
int[] pointB = { 2, 5 };
int[] pointC = { 7, 5 };
int[] pointD = { 8, 2 };
char[] pointName = { 'A', 'B', 'C', 'D' };

Console.WriteLine();
int[,] newCoords = ScaleCoords(pointA, pointB, pointC, pointD, k);
PrintCoords(newCoords, pointName);