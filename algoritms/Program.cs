
//создание 2ух мерного масива рандомными числами
//---------------------------------------------------------
Console.Clear();

Console.Write("Введите количество строк в двухмерном массиве: ");
int arrayLine = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов в двухмерном массиве: ");
int arrayColumns = int.Parse(Console.ReadLine());

int[,] binaryArray = new int[arrayLine, arrayColumns];

void fillBinaryArray(int[,] binaryArray)
{
    for (int i = 0; i < binaryArray.GetLength(0); i++)
    {
        for (int j = 0; j < binaryArray.GetLength(1); j++)
        {
            binaryArray[i, j] = new Random().Next(0, 10);
        }
    }
}
fillBinaryArray(binaryArray);
//---------------------------------------------------------

// вывод двухмерного масива
//---------------------------------------------------------
void outBinaryArray(int[,] array)
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
outBinaryArray(binaryArray);
//---------------------------------------------------------


//создание масива рандомными числами
//---------------------------------------------------------
Console.Write("Введите количество элементов в масиве: ");
int number = int.Parse(Console.ReadLine());

int[] array = new int[number];

void fillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}

fillArray(array); // передача масива
//---------------------------------------------------------


// вывод  масива
//---------------------------------------------------------
void outArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");  //вывод массива
    }
    Console.WriteLine("");
}
outArray(array);
//---------------------------------------------------------


//---------------------------------------------------------
// Генерация дробного случайного число от а до 2
Console.Write("Введите минимальное значение для генерации дробного числа: ");
int minDouble = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение для генерации дробного числа: ");
int maxDouble = int.Parse(Console.ReadLine());

double GetRandomDouble(int min, int max)
{
    return Math.Round((new Random().NextDouble() * (max - min) + min), 5);
}

Console.WriteLine($"Рандомное дробное число в диапазоне от {minDouble} до {maxDouble} = {GetRandomDouble(minDouble, maxDouble)}");