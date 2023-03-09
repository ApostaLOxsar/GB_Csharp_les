//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

int[] array = new int[10];

void fillarray (int collect)
{
    for(int i = 0; i < collect; i++)
    {
        array[i]= new Random().Next(0,20);
        Console.Write($"{array[i]}, ");  //вывод массива
    }
    Console.WriteLine("");
}

void foundIndex1 (int number,int[] array)
{
    int index = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            index = i;
            Console.WriteLine("да");
            break;
        }
    }
    if (index == -1)
    {
        Console.WriteLine("нет");
    }
}

fillarray (array.Length);

Console.Write("введите число: ");
int number = int.Parse(Console.ReadLine());

foundIndex1 (number, array);