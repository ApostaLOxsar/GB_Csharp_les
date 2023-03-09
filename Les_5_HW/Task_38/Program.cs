/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Максимальная и минимальная граница указаны перманентно 5 и 2 соотвецтвенно (рандом возвращает от 0 до 1), можно попросить с консоли, но зачем)))
Так же округлил до 5го знака после запятой, без этого много цифр))
вывод макс и мин так же можно реализовать через out min, out max либо через 2а разных метода и перебирать масив дважды, но зачем)
*/


Console.Clear();

Console.Write("Введите количество элементов в масиве: ");
int number = int.Parse(Console.ReadLine());


double[] array = new double[number];
void fillarray (double collect)
{
    for(int i = 0; i < collect; i++)
    {
        int maximum = 5;
        int minimum = 2;
        array[i]= Math.Round((new Random().NextDouble() * (maximum - minimum) + minimum), 5);
        Console.Write($"{array[i]}  ");  //вывод массива
    }
    Console.WriteLine("");
}

double getDifMaxMin (double[] array)
{   
    double min = array[0];
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    Console.WriteLine($"Максимальный элемент в масиве равен = {max}");
    Console.WriteLine($"Минимальный элемент в масиве равен = {min}");
    return Math.Round(max - min, 5);
}


fillarray (array.Length);
Console.WriteLine($"{getDifMaxMin(array)}");