//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



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

void GetSumElementMassInNewMass(int[,] array, int[] result)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[i] += array[i, j];
        }
    }
}

int GetNumberMin (int[] result)
{
    int min = 0;
    for (int i = 1; i < result.Length; i++)
    {
        if (result[min] > result[i]) min = i;
    }
    return min;
}

Console.Write("Введите количество строк в двухмерном массиве: ");
int arrayLine = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов в двухмерном массиве: ");
int arrayColumns = int.Parse(Console.ReadLine());

int[,] binaryArray = new int[arrayLine, arrayColumns];
int[] result = new int[binaryArray.GetLength(0)];



FillBinaryArray(binaryArray);
OutBinaryArray(binaryArray);
GetSumElementMassInNewMass(binaryArray, result);
int min = GetNumberMin(result);

Console.WriteLine($"индекс строки с наименьшей суммой элементов : {min}");
for (int j = 0; j < binaryArray.GetLength(1); j++)
{
    Console.Write($"{binaryArray[min, j]} ");
}