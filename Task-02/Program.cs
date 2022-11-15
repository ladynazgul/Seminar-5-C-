// Написать программу преобразования десятичного числа в двоичное
// Как вариант - решение Вячеслава

int GetNumber()
{
    Console.WriteLine("Введите число: ");
    int number = int.Parse(Console.ReadLine() ?? "0"); // Этот метод для получения десятичного числа
    return number;
}

void ShowNumber(int[] Array, int PowNumber) // Выводит массив на экран
{
    for(int k = 0; k < PowNumber; k++)
    {
        Console.Write(Array[k]);
    }
}

int number = GetNumber(); // Определяем размер массива, в который будем записывать единички и нолики
int Pow = 0;
int i = 0;
while(Math.Pow(2, i) <= number)
{
    Pow = i;
    i++;
}
Pow++;
Console.WriteLine($"Степень равна {Pow - 1}");

int[] Array = new int[Pow]; // Заполняем массив остатками от деления на 2
int result = 0;
for(int j = Pow-1; j >= 0; j--)
{
    result = number % 2;
    Array[j] = result;
    number = number / 2;
}

ShowNumber(Array, Pow);
Console.WriteLine();

// Работает, но че-то как-то сложновато:))) Код очень длинный.