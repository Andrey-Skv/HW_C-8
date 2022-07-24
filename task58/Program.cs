//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

void printArray(int[,] arr1)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            Console.Write($"{arr1[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrixComposition(int[,] arr, int[,] arr1)
{
    int[,] result = new int[arr.GetLength(0), arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            result[i, j] = arr[i, j] * arr1[i, j];
        }
    }
    return result;
}

Console.WriteLine("Задайте массив");
Console.Write("Количество строк = ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов = ");
int colums = Convert.ToInt32(Console.ReadLine());

while (lines <= 0 || colums <= 0)
{
    Console.Write("Количество строк = ");
    lines = Convert.ToInt32(Console.ReadLine());
    Console.Write("Количество столбцов = ");
    colums = Convert.ToInt32(Console.ReadLine());
}

int[,] array = getArray(lines, colums);
int[,] array1 = getArray(lines, colums);
int[,] array3 = matrixComposition(array1, array);
printArray(array);
Console.WriteLine();
printArray(array1);
Console.WriteLine();
printArray(array3);