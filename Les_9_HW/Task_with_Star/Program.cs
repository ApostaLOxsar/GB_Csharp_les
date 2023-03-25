// Найти второй максимум в массиве.

void OutArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");  //вывод массива
    }
    Console.WriteLine();
}

Console.Clear();

int max1;
int max2;


void PrintMax(int[] array)
{
    if (array[0] >= 0)
    {
        max1 = -array[0];
        max2 = -array[0];
    }
    else
    {
        max1 = array[0];
        max2 = array[0];
    }

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= max1)
        {
            max1 = array[i];
        }
    }

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= max2 && array[i] != max1)
        {
            max2 = array[i];
        }
    }

    Console.WriteLine($"1ый максимум {max1}");
    Console.WriteLine($"2ой максимум {max2}");
    
}


//основныые вариации масивов которые могут вызвать проблемы
//неучтен только вариант когда ввесь массив одинаков
int[] array = { 5, 5, 0, 1, 5 };
Console.WriteLine();
OutArray(array);
PrintMax(array);

array[0] = 4;
array[1] = 5;
array[2] = 0;
array[3] = 1;
array[4] = 5;
Console.WriteLine();
OutArray(array);
PrintMax(array);


array[0] = 4;
array[1] = 4;
array[2] = 0;
array[3] = 1;
array[4] = 5;
Console.WriteLine();
OutArray(array);
PrintMax(array);

array[0] = 0;
array[1] = 5;
array[2] = 0;
array[3] = 1;
array[4] = 0;
Console.WriteLine();
OutArray(array);
PrintMax(array);

array[0] = -5;
array[1] = -5;
array[2] = 0;
array[3] = -1;
array[4] = -5;
Console.WriteLine();
OutArray(array);
PrintMax(array);

Console.WriteLine("для поиска в массиве заданном вручную нажмите enter");
string retur = Console.ReadLine();

while (retur == "")
{
    Console.Clear();
    ReturnFound();
    Console.WriteLine("для повтора нажмите {enter}");
    retur = Console.ReadLine();
}

void ReturnFound()
{
    Console.WriteLine("Введите количество елементов в массиве");
    int columns = int.Parse(Console.ReadLine());

    int[] array2 = new int[columns];

    Console.WriteLine("Введите массив через enter");
    for (int i = 0; i < array2.Length; i++)
    {
        array2[i] = int.Parse(Console.ReadLine());
    }
    OutArray(array2);
    PrintMax(array2);
}