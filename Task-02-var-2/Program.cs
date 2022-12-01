// Задача про перевод из десятичной в двоичную систему. Решение Наты

// int GetNumber()
// {
//     Console.WriteLine("Введите число: ");
//     int number = int.Parse(Console.ReadLine() ?? "0"); // Этот метод для получения десятичного числа
//     return number;
// }

// int[] ConvertToBinary(int num)
// {
//     int num2 = num;
//     int size = 0;
//     while (num > 0)
//     {
//         num = num / 2;
//         size++;
//     }

//     int[] binary = new int[size];
//     for (int i = size - 1; i >= 0; i--)
//     {
//         binary[i] = num2 % 2;
//         num2 = num2 / 2;
//     }
//     return binary;
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i]);
//     }
// }

// PrintArray(ConvertToBinary(GetNumber()));

// Решение препода

int number = int.Parse(Console.ReadLine() ?? "0");
int copy = number;
int answer = 0;
while (copy > 0)
{
    int rest = copy % 2;
    answer *= 10;
    answer += rest;
    copy /= 2;
}
if (number % 2 == 0)
    answer *= 10;
Console.WriteLine(answer);