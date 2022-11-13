void FillArray(int[] array)
{
    for(int i=0;i<array.Length;i++)
    {
        Console.Write($"Enter {i + 1} element of array: ");
        array[i] = int.Parse(Console.ReadLine() ?? "0");
    }
}
int[] CreateArray(int length)
{
    int[] array = new int[length];
    for(int i=0;i<length;i++)
    {
        Console.Write($"Enter {i + 1} element of array: ");
        array[i] = int.Parse(Console.ReadLine() ?? "0");
    }
    return array;
}
void PrintArray(int[] array)
{
    for(int i=0;i<array.Length;i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}
int[] createdArray = CreateArray(5);
PrintArray(createdArray);
Console.WriteLine();
int[] array = new int[5];
FillArray(array);
PrintArray(array);