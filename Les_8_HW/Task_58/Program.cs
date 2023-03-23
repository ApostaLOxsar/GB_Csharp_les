//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();

void FillBinaryArray(int[,] binaryArray)
{
    for (int i = 0; i < binaryArray.GetLength(0); i++)
    {
        for (int j = 0; j < binaryArray.GetLength(1); j++)
        {
            binaryArray[i, j] = new Random().Next(0, 10);
        }
    }
}

void OutBinaryArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");  //вывод массива
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MultiplicationTwoArray(int[,] matrix1, int[,] matrix2, ref int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
}


Console.Write("Введите количество строк в 1ой матрице: ");
int arrayLineInMatrix1 = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов в 1ой матрице: ");
int arrayColumnsInMatrix1 = int.Parse(Console.ReadLine());

int[,] arrayMatrix1 = new int[arrayLineInMatrix1, arrayColumnsInMatrix1];



Console.Write("Введите количество строк в 2ой матрице: ");
int arrayLineInMatrix2 = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов в 2ой матрице: ");
int arrayColumnsInMatrix2 = int.Parse(Console.ReadLine());

int[,] arrayMatrix2 = new int[arrayLineInMatrix2, arrayColumnsInMatrix2];




FillBinaryArray(arrayMatrix1);
FillBinaryArray(arrayMatrix2);
OutBinaryArray(arrayMatrix1);
OutBinaryArray(arrayMatrix2);

int[,] result = new int[arrayMatrix1.GetLength(0), arrayMatrix2.GetLength(1)];

if (arrayMatrix1.GetLength(0) == arrayMatrix2.GetLength(1))
{
    MultiplicationTwoArray(arrayMatrix1, arrayMatrix2, ref result);
    OutBinaryArray(result);
}
else Console.WriteLine("Матрицы невозможно перемножить :/");
