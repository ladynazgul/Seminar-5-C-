// 46. Написать программу масштабирования фигуры

// Масштабирование равностороннего четырехугольника. (Левый нижний угол (точка А) остается на месте)

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
        if (j % 2 == 0) 
            Console.Write($"( {array[i,j]} , ");
        else
            Console.Write($"{array[i,j]} )  "); 
    }
}
double Scale(double[,] arr, double k)
{
    double [,] NewArray = new double[arr.GetLength(0),arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
       for (int j = 0; j < arr.GetLength(1); j++)
       {
           NewArray[i,j] = arr[i,j] * k;
       }
    }
    return NewArray;
}