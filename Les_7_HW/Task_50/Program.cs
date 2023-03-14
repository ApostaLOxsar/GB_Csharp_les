//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Если она принимает значение тогда просто Console.WriteLine($"Искомый элемент находится на позиции [{а},{б}] = {binaryArray[а, б]}");
//Если поиск элемента с заданым значением тогда

/*
for (int i = 0; i < binaryArray.GetLength(0); i++)
    {
        for (int j = 0; j < binaryArray.GetLength(1); j++)
        {
            if (binaryArray[i, j] == foundIndex)
            {
                Console.WriteLine($"Искомый элемент находится на позиции [{i},{j}] = {binaryArray[i, j]}");
                break;
            }
            else Console.WriteLine("Такого элемента нет");

        }
    }
*/

Console.Clear();

Console.Write("Введите количество строк в двухмерном массиве: ");
int arrayLine = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов в двухмерном массиве: ");
int arrayColumns = int.Parse(Console.ReadLine());

int[,] binaryArray = new int[arrayLine, arrayColumns];

void fillBinaryArray(int[,] binaryArray)
{
    int temp = 0;
    for (int i = 0; i < binaryArray.GetLength(0); i++)
    {
        for (int j = 0; j < binaryArray.GetLength(1); j++)
        {
            binaryArray[i, j] = temp; //new Random().Next(0, 10);
            temp++;
            Console.Write(binaryArray[i, j] +" ");
        }
        Console.WriteLine();
    }
}
fillBinaryArray(binaryArray);

//Как я понял мы задаём номер элемента а не его позицию x,y
//Так как в примере вводится только 1 значение
Console.Write("Введите номер искомого элемента: ");
int foundIndex = int.Parse(Console.ReadLine());

if (foundIndex > binaryArray.Length - 1)
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    int foundI = foundIndex / (binaryArray.GetLength(0) + 1);
    int foundJ = foundIndex % binaryArray.GetLength(1);
    Console.WriteLine($"Искомый элемент находится на позиции [{foundI},{foundJ}] = {binaryArray[foundI, foundJ]}");
}
