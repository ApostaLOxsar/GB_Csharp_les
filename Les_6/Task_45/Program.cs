// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.Clear();
Console.Write("Введите количество элементов в масиве: ");
int number = int.Parse(Console.ReadLine());
int[] array = new int[number];

void fillarray (int collect)
{
    for(int i = 0; i < collect; i++)
    {
        array[i]= new Random().Next(0,100);
        Console.Write($"{array[i]}, ");  //вывод массива
    }
    Console.WriteLine("");
}

fillarray(number);
int[] array_2 = new int[array.Length];

/*for(int i = 0; i < array.Length; i++)
{
    array_2[i] = array[i];
    Console.Write($"{array[i]}, ");  //вывод массива
}*/

Array.Copy(array, array_2, array.Length);


for(int i = 0; i < array.Length; i++)
{
    Console.Write($"{array_2[i]}, ");  //вывод массива
}