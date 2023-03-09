// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];

void fillarray (int collect)
{
    for(int i = 0; i < 8; i++)
    {
        array[i]= new Random().Next(0,11);
        Console.Write($"{array[i]}  ");
    }
}

fillarray (8);