//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

Console.Write("Введите количество строк в двухмерном массиве: ");
int arrayLine = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов в двухмерном массиве: ");
int arrayColumns = int.Parse(Console.ReadLine());

int[,] binaryArray = new int[arrayLine, arrayColumns];

double[] averege = new double[arrayColumns];

void fillBinaryArray(int[,] binaryArray)
{
    for (int i = 0; i < binaryArray.GetLength(0); i++)
    {
        for (int j = 0; j < binaryArray.GetLength(1); j++)
        {
            binaryArray[i, j] = new Random().Next(0, 10);
            Console.Write(binaryArray[i, j] +"   ");
        }
        Console.WriteLine();
    }
}

void GetAverege (int[,] binaryArray) {
int k = 0;
for (int j = 0; j < binaryArray.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < binaryArray.GetLength(0); i++)
        {
            sum += binaryArray[i, j];
        }
        averege[k] = Math.Round(sum / (double)binaryArray.GetLength(0), 1);
        k++;
    }
}

fillBinaryArray(binaryArray);
GetAverege(binaryArray);

Console.WriteLine();
for (int i = 0; i < averege.Length; i++)
    {
        Console.Write(averege[i] +"  ");
    }