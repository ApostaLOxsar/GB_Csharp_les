
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

double getDifMaxMin (double[] array, out double max, out double min)
{   
    min = array[0];
    max = array[0];
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
    return Math.Round(max - min, 5);
}

double min;
double max;
fillarray (array.Length);
Console.WriteLine($"Разница минимального и максимального элемента равна: {getDifMaxMin(array, out max, out min)}");
Console.WriteLine($"Максимальный элемент в масиве равен = {max}");
Console.WriteLine($"Минимальный элемент в масиве равен = {min}");