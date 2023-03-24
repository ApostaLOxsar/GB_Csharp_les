//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
        Console.WriteLine("");
    }
}

void GetSortMassiv(int[,] array)
{
    int[] tempMassiv = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempMassiv[j] = array[i, j];
        }
        //Array.Sort(tempMassiv);
        for (int j = 0; j < tempMassiv.Length - 1; j++)//Сортировка *руками*
        {

            for (int k = j + 1; k < tempMassiv.Length; k++)
            {
                if (tempMassiv[k] >= tempMassiv[j]) (tempMassiv[j], tempMassiv[k]) = (tempMassiv[k], tempMassiv[j]);
            }

        } 

        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = tempMassiv[j];
        }
    }
}
Console.Clear();

Console.Write("Введите количество строк в двухмерном массиве: ");
int arrayLine = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов в двухмерном массиве: ");
int arrayColumns = int.Parse(Console.ReadLine());

int[,] binaryArray = new int[arrayLine, arrayColumns];



FillBinaryArray(binaryArray);
OutBinaryArray(binaryArray);
Console.WriteLine();
GetSortMassiv(binaryArray);
OutBinaryArray(binaryArray);