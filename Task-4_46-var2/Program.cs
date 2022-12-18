// Масштабирование фигуры, вариант 2

int k = 2;
int[] pointA = { 3, 2 };
int[] pointB = { 2, 5 };
int[] pointC = { 7, 5 };
int[] pointD = { 8, 2 };
char[] pointName = { 'A', 'B', 'C', 'D' };

int[] MergeArray(int[] arr1, int[] arr2, int[] arr3, int[] arr4)
{
    int[] u1 = arr1.Concat(arr2).ToArray();
    int[] u2 = u1.Concat(arr3).ToArray();
    int[] unitedArr = u2.Concat(arr4).ToArray();
    return unitedArr;
}

int[] GetScalingCoords(int[] arr, int k)
{
    int[] newCoords = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (i <  2) newCoords[i] = arr[i];
        else if (i > 1 && i % 2 == 0) newCoords[i] = arr[i] * k - arr[0] * (k - 1);
        else if (i > 1 && i % 2 != 0) newCoords[i] = arr[i] * k - arr[1] * (k - 1);
    }
    return newCoords;
}

void PrintArray(int[] arr, char[] letters)
{
    int j = 0;
    for (int i =0; i < arr.Length; i++)
    {
        if (i % 2 == 0)Console.Write($"{letters[j]} ({arr[i]}, ");
        else if (i % 2 != 0)
        {
            Console.WriteLine($"{arr[i]})");
            j++;
        }
    }
}

Console.WriteLine();
int[] unitedCoords = (MergeArray(pointA, pointB, pointC, pointD));
int[] scalingCoords = GetScalingCoords(unitedCoords, k);
PrintArray(scalingCoords, pointName);
