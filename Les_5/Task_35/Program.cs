//Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

int[] array = new int[123];

void fillarray (int collect)
{
    for(int i = 0; i < collect; i++)
    {
        array[i]= new Random().Next(0,20);
        Console.Write($"{array[i]}, ");  //вывод массива
    }
    Console.WriteLine("");
}

int foundSum (int[] array, int max, int min)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i] <= max)
        {
            sum++;
        }
    }

    return sum;
}


Console.Write("введите минимальное значение поиска: ");
int min = int.Parse(Console.ReadLine());

Console.Write("введите максимальное значение поиска: ");
int max = int.Parse(Console.ReadLine());

fillarray (array.Length);
Console.WriteLine($"Количество элементов в отрезке от {min} до {max} включительно = {foundSum(array, max, min)}");