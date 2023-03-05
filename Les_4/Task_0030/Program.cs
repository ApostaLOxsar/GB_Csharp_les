//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
int[] array = new int[20];

void fillarray (int collect)
{
    for(int i = 0; i < collect; i++)
    {
        array[i]= new Random().Next(0,20);
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine("");
}


int foundIndex (int number,int[] array)
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
int index = foundIndex (number, array);

if (index == -1)
    {
    Console.WriteLine("элемент не найден");
    }
else
    {
    Console.WriteLine($"элемент № {index}");
    }
