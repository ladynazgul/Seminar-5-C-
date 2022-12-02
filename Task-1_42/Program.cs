// // Задача 42: Определить сколько чисел больше 0 введено с клавиатуры
// // Решение с методами

// int GetArrayLength()
// {
//     Console.WriteLine("Укажите количество чисел, которые будут вводиться с клавиатуры: ");
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     return number;
// }

// void FillArray(int[] Array)
// {
//     for(int i = 0; i < Array.Length; i++)
//     {
//         Console.WriteLine($"Введите {i + 1} число: ");
//         Array[i] = int.Parse(Console.ReadLine() ?? "0");
//     }
// }

// void ShowNumbers(int[] Array)
// {
//     for(int i = 0; i < Array.Length; i++)
//     Console.Write($"{Array[i]} ");
// }

// int CheckArray(int[] Array)
// {
//     int result = 0;
//     for(int i = 0; i < Array.Length; i++)
//     {
//         if (Array[i] > 0)
//             result++;
//     }
//     return result;
// }

// int Length = GetArrayLength();
// int[] Numbers = new int[Length];
// FillArray(Numbers);
// ShowNumbers(Numbers);
// int count = CheckArray(Numbers);
// Console.WriteLine();

// Console.WriteLine($"Данный массив содержит {count} чисел больше 0");

// Решение без методов и массивов

int length = 10;
int count = 0;

while (length > 0)
{
    Console.Write("Введите число: ");
    string num = Console.ReadLine() ?? "0";
    int number = int.Parse(num);
    if (number > 0)
        count++;
        length--;
}

Console.WriteLine($"Количество чисел больше 0: {count}");