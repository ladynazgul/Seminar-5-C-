// Показать числа Фибоначчи

int N = new Random().Next(1, 30);
Console.WriteLine($"Сколько чисел показать: {N}");

int[] GetFibonacci(int N)
{
    int n1 = 1;
    int n2 = 1;
    int[] fib = new int[N];
    fib[0] = 1;
    fib[1] = 1;
    for (int i = 2; i < N; i++)
    {
        fib[i] = n1 + n2;
        n2 = n1;
        n1 = fib[i];
    }
    return fib;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

PrintArray(GetFibonacci(N));
Console.WriteLine();
