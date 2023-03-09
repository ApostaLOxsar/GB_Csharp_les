//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


Console.Clear();
Console.Write("Введите количество элементов в масиве: ");
int number = int.Parse(Console.ReadLine());
int[] array = new int[number];

void fillarray (int collect)
{
    for(int i = 0; i < collect; i++)
    {
        array[i]= new Random().Next(0,10);
        Console.Write($"{array[i]}, ");  //вывод массива
    }
    Console.WriteLine("");
}

int getSumNoeven (int[] array)
{
    int temp = 0;
    for(int i = 1; i < array.Length; i += 2)
    {
        temp += array[i];
    }
    return temp;
}


fillarray (array.Length);
Console.WriteLine($"сумму элементов, стоящих на нечётных позициях равна :{getSumNoeven(array)} ");
