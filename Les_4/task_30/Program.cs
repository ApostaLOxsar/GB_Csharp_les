//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке

int[] array = new int[8];

void fillarray (int collect)
{
    for(int i = 0; i < 8; i++)
    {
        array[i]= new Random().Next(0,2);
        Console.Write($"{array[i]}  ");
    }
}

fillarray (8);