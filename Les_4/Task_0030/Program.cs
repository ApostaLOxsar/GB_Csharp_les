//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
using System.Diagnostics;
using System;

Console.Clear();

Stopwatch stopwatchper = new Stopwatch();
Stopwatch stopwatchbin = new Stopwatch();

int[] array = new int[20000000];

void fillarray (int collect)
{
    for(int i = 0; i < collect; i++)
    {
        array[i]= new Random().Next(0,200000);
        //Console.Write($"{array[i]}, ");  //вывод массива
    }
    //Console.WriteLine("");
}

int foundIndex2 (int number,int[] array)
{
    Array.Sort(array);
     int Left = 0; 
     int Right = array.Length - 1;
     int k = (Right + Left) / 2;
     while (Left<Right-1)
     {
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
     return k;
}

int foundIndex1 (int number,int[] array)
{
    int index = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            index = i;
            break;
        }
    }

    return index;
}

fillarray (array.Length);

Console.Write("введите число: ");
int number = int.Parse(Console.ReadLine());

stopwatchper.Start();
int index1 = foundIndex1 (number, array);
stopwatchper.Stop();

stopwatchbin.Start();
int index2 = foundIndex2 (number, array);
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

Console.WriteLine($"количество тактов перебором :{stopwatchper.ElapsedTicks}");
Console.WriteLine($"количество тактов бинарным :{stopwatchbin.ElapsedTicks}");

Console.WriteLine($"время перебором :{stopwatchper.ElapsedMilliseconds}");
Console.WriteLine($"время бинарным :{stopwatchbin.ElapsedMilliseconds}");