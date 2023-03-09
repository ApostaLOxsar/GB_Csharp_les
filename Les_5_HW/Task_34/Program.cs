//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. 
// если перенести инициализацию массива в конец то возникает error (CS0841: Невозможно использовать локальную переменную "array" перед ее объявлением. в 13 и 14 строке) а почему так если это методыи и они должны вызываться после отсылки к им в коде?

Console.Clear();
Console.Write("Введите количество элементов в масиве: ");
int number = int.Parse(Console.ReadLine());
int[] array = new int[number];

void fillarray (int collect)
{
    for(int i = 0; i < collect; i++)
    {
        array[i]= new Random().Next(100,1000);
        Console.Write($"{array[i]}, ");  //вывод массива
    }
    Console.WriteLine("");
}

int getSumEven (int[] array)
{
    int temp = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) temp++;
    }
    return temp;
}

/*Console.Write("Введите количество элементов в масиве: ");
//int number = int.Parse(Console.ReadLine());
int[] array = new int[number];*/

fillarray (array.Length);
Console.WriteLine($"в масивве {getSumEven(array)} четных элемента");
