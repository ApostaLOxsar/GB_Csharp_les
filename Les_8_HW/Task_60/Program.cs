//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//Вместо рандомных чисел можно было заполнить последовательно от 10 до 99 и не изобретать велосипед))))

void FillBinaryArray(int[,,] binaryArray)
{
    for (int i = 0; i < binaryArray.GetLength(0); i++)
    {
        for (int j = 0; j < binaryArray.GetLength(1); j++)
        {
            for (int k = 0; k < binaryArray.GetLength(2); k++)
            {
                bool numberFound = true;
                int temp = new Random().Next(10, 100);
                foreach (int temp1 in binaryArray)
                {
                    if (temp1 == temp)
                    {
                        numberFound = false;
                        break;
                    }
                }
                if (numberFound) binaryArray[i, j, k] = temp;
                else k--;
            }
        }
    }
}

void OutBinaryArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k})    ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите количество строк в двухмерном массиве: ");
int arrayLine = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов в двухмерном массиве: ");
int arrayColumns = int.Parse(Console.ReadLine());

Console.Write("Введите количество плоскостей в двухмерном массиве: ");
int arrayPlane = int.Parse(Console.ReadLine());

int[,,] triplArray = new int[arrayPlane, arrayLine, arrayColumns];

Console.WriteLine();

if (arrayLine * arrayColumns * arrayPlane < 100)
{
    FillBinaryArray(triplArray);
    OutBinaryArray(triplArray);
}
else Console.WriteLine("Невозможно заполнить матрицу элементов больше чем чисел от 10 до 99");
