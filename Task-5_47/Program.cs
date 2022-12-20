// Написать программу копирования массива

int[] GetArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

int[] CopyArray(int[] initialArray)
{
    int[] copy = new int[initialArray.Length];
    for (int i = 0; i < initialArray.Length; i++)
    {
        copy[i] = initialArray[i];
    }
    return copy;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int[] initial = GetArray(10, 1, 100);
Console.WriteLine("Исходный массив:");
PrintArray(initial);
Console.WriteLine();
Console.WriteLine("Копия массива:");
int[] copy = CopyArray(initial);
PrintArray(copy);