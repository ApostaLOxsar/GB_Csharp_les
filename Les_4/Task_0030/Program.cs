//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
using System.Diagnostics;

Console.Clear();

Stopwatch stopwatchper = new Stopwatch();
Stopwatch stopwatchbin = new Stopwatch();
Stopwatch stopwatchbinnosort;

int[] array = new int[20000000];
int counter1, counter2;

void fillarray (int collect)
{
    for(int i = 0; i < collect; i++)
    {
        array[i]= new Random().Next(0,200000);
        //Console.Write($"{array[i]}, ");  //вывод массива
    }
    //Console.WriteLine("");
}

int foundIndex2 (int number,int[] array, out int counter2, out Stopwatch stopwatchbinnosort)
{
    Array.Sort(array);
     int Left = 0; 
     int Right = array.Length - 1;
     int k = (Right + Left) / 2;
     counter2 = 0;
     stopwatchbinnosort = new Stopwatch();

     stopwatchbinnosort.Start();
     while (Left<Right-1)
     {
        counter2++;
        k = (Right + Left) / 2;
        if (array[k] == number)         
           break;
        if (array[k] < number)
           Left = k;
        else
           Right = k;
     }
     if (array[k] != number)
     {
        counter2++;
        if (array[Left] == number)
           k = Left;
        else
        {
           if (array[Right] == number)
              k = Right;
           else
              k = -1;
        };
     }
    stopwatchbinnosort.Stop();
    return k;
}

int foundIndex1 (int number,int[] array, out int counter1)
{
    int index = -1;
    counter1 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        counter1++;
        if (array[i] == number)
        {
            index = i;
            break;
        }
    }

    return index;
}
 
fillarray (array.Length);

/*Console.Write("введите число: ");
int number = int.Parse(Console.ReadLine());*/
int number = new Random().Next(0,200000);
Console.WriteLine($"Искомое число: {number}");

stopwatchper.Start();
int index1 = foundIndex1 (number, array, out counter1);
stopwatchper.Stop();

stopwatchbin.Start();
int index2 = foundIndex2 (number, array, out counter2, out stopwatchbinnosort);
stopwatchbin.Stop();

if (index1 == -1)
    {
    Console.WriteLine("элемент не найден");
    }
else
    {
    Console.WriteLine($"элемент № перебором {index1}");
    }
if (index2 == -1)
    {
    Console.WriteLine("элемент не найден");
    }
else
    {
    Console.WriteLine($"элемент № бинарным {index2}");
    }
Console.WriteLine();

Console.WriteLine($"количество тактов перебором :{stopwatchper.ElapsedTicks}");
Console.WriteLine($"количество тактов бинарным + сортировка:{stopwatchbin.ElapsedTicks}");
Console.WriteLine($"количество тактов бинарным без сортировки :{stopwatchbinnosort.ElapsedTicks}");
Console.WriteLine();

Console.WriteLine($"время перебором :{stopwatchper.ElapsedMilliseconds}");
Console.WriteLine($"время бинарным :{stopwatchbin.ElapsedMilliseconds}");
Console.WriteLine($"время бинарным без сортировки :{stopwatchbinnosort.ElapsedMilliseconds}");
Console.WriteLine();

Console.WriteLine($"Циклов перебором :{counter1}");
Console.WriteLine($"Циклов бинарным :{counter2}");