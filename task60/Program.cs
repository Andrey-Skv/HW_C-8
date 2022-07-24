// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[] getArray(int a)
{
    int[] result = new int[a];
    for (int i = 0; i < a; i++)
    {
        result[i] = new Random().Next(0, 10);
    }
    return result;
}

int[] uniqMeaning(int[] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int uniqEllement = arr[i];
        for (int j = i + 1; j < arr.GetLength(0); j++)
        {
            if (arr[i] == arr[j])
            {
                arr[j] = new Random().Next(10, 100);
            }
        }
    }
    return arr;
}

int[,,] array3D(int[] arr, int lines, int colums, int depth)
{
    int[,,] arrayCube = new int[lines, colums, depth];
    int n = 0;
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                arrayCube[i, j, k] = arr[n];
                n++;
            }
        }
    }
    return arrayCube;
}

void PrintArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        string strTab = "";
        for (int h = 0; h < arr.GetLength(2); h++)
        {
            string str = "";
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                str += String.Format("[{0},{1},{2}]={3, -6}", i, j, h, arr[i, j, h]);
            }
            Console.WriteLine(strTab + str);
            strTab += "  ";
        }
        Console.WriteLine();
    }
}

int line = 2;
int column = 2;
int depth = 2;
int numbers = line * column * depth;

int[] matrix = new int[numbers];
matrix = getArray(numbers);
uniqMeaning(matrix);
PrintArray(array3D(matrix, line, column, depth));