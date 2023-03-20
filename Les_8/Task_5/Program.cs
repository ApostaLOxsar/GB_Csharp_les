Console.Clear();

int row = int.Parse(Console.ReadLine());
int[,] triangle = new int[row, row];
const int cellWidht = 3;

void FillTriangle()
{
    for (int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }

    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
}

void PrintTriangle()
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            if (triangle[i, j] != 0) Console.Write($"{triangle[i, j],cellWidht}");
        }
        Console.WriteLine();
    }
}

void PrintTabTriangle()
{
    int col = cellWidht * row;

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            if (triangle[i, j] != 0) Console.Write($"{triangle[i, j],cellWidht}");
            col += cellWidht * 2;
        }
        col = cellWidht * row - cellWidht * (i + 1);

        Console.WriteLine();
    }
}

FillTriangle();
PrintTabTriangle();