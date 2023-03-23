// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.(Данная програма заполняет любой массив)
//if перед циклом добавлено для исключение перезаписывание центральной части

//Так же хотелось услышать ваши коментарии по поводу написание кода (оформление табуляция инициализация переменных и т.п.) так же хотел услышать по поводу использовоние рекурсии (коректна ли условие выхода для её)
//а если еще и пару слов про гит(коректность комитов и т.п.), было бы супер)

Console.Clear();

void OutBinaryArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");  //вывод массива
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.Write("Введите количество строк в двухмерном массиве: ");
int arrayLine = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов в двухмерном массиве: ");
int arrayColumns = int.Parse(Console.ReadLine());

int[,] array = new int[arrayLine, arrayColumns];


int s = 0;
int starti = array.GetLength(0);
int startj = array.GetLength(1);

void GetFillMasiv(int[,] array, int i, int j, int starti, int startj)
{
    for (int sj = startj; sj < j; sj++) //движение вправо
    {
        array[starti, sj] = s;
        s++;
    }
    if (array[starti + 1, j - 1] == 0)
    {
        for (int si = starti + 1; si < i; si++) //движение вниз
        {
            array[si, j - 1] = s;
            s++;
        }
    }
    if (array[i - 1, j - 2] == 0)
    {
        for (int sj = j - 2; sj >= startj; sj--) //движение влево
        {
            array[i - 1, sj] = s;
            s++;
        }
    }
    if (array[i - 2, startj] == 0)
    {
        for (int si = i - 2; si > starti; si--) //движение вверх
        {
            array[si, startj] = s;
            s++;
        }
    }
    if ((array.GetLength(0) - 1) / 2 > starti && (array.GetLength(1) - 1) / 2 > startj) GetFillMasiv(array, i - 1, j - 1, starti + 1, startj + 1);
}

GetFillMasiv(array, starti, startj, 0, 0);
Console.WriteLine();
OutBinaryArray(array);
