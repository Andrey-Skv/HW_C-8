// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.

int[,] getArray(int a, int b)
{
    int[,] result = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void printArray(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write($"{array1[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] arrSumm(int[,] array1)
{
    int[] arr = new int[array1.GetLength(0)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            summ += array1[i, j];
        }
        arr[i] = summ;
    }
    return arr;
}


int MinSum(int[] arr)
{
    int min = arr[0];
    int numString = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            numString = i;
        }

    }
    return numString;

}

int[,] array = getArray(4, 3);
printArray(array);
int NumStringMin = MinSum(arrSumm(array));
Console.WriteLine($"Минимальная сумма элементов в строке: {NumStringMin + 1}");