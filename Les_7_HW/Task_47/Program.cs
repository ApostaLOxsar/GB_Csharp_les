// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();

Console.Write("Введите количество строк в двухмерном массиве: ");
int arrayLine = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов в двухмерном массиве: ");
int arrayColumns = int.Parse(Console.ReadLine());

double[,] binaryArray = new double[arrayLine, arrayColumns];

void fillBinaryArray(double[,] binaryArray)
{
    int max = 10;
    int min = -10;

    for (int i = 0; i < binaryArray.GetLength(0); i++)
    {
        for (int j = 0; j < binaryArray.GetLength(1); j++)
        {
            binaryArray[i, j] = Math.Round((new Random().NextDouble() * (max - min) + min), 1);
        }
    }
}

void outBinaryArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");  //вывод массива
        }
        Console.WriteLine("");
    }
}

fillBinaryArray(binaryArray);
outBinaryArray(binaryArray);