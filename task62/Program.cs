//Заполните спирально массив 4 на 4.

int n = 4;
int x = 0;
int y = 0;
int dx = 1;
int dy = 0;
int[,] array = new int[n, n];

for (int i = 0; i < n * n; i++)
{
    array[y, x] = i + 1;
    int test = 0;
    if (dx != 0) test = x + dx;
    else test = y + dy;
    if (test < 0 || test == n || array[y + dy, x + dx] != 0)
    {
        int oldX = dx;
        dx = -dy;
        dy = oldX;
    }
    y += dy;
    x += dx;
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + "  ");
    }
    Console.WriteLine();
}