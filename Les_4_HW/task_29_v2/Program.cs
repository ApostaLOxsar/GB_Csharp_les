// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];

void input (int collect)
{
    for(int i = 0; i < 8; i++)
    {
        Console.Write("введите число: ");
        array[i]= int.Parse(Console.ReadLine());
    }
}

void output (int[] array)
{
    for(int i = 0; i < 8; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}

input (8);
output (array);
