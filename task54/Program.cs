// Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int k = 0;
            while (k < array.GetLength(1) - 1)
            {
                if (array[i, k + 1] > array[i, k])
                {
                    int x = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = x;
                    k++;
                }
                k++;

            }

        }
    }
    return array;
}

int a = 3;
int b = 3;
int[,] array1 = getArray(a, b);
printArray(array1);
Console.WriteLine();
printArray(SortArray(array1));