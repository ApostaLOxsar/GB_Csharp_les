// Найти второй максимум в массиве.

void OutArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");  //вывод массива
    }
    Console.WriteLine();
}

Console.Clear();

Console.WriteLine("Введите количество елемнтов в массиве");
int columns = int.Parse(Console.ReadLine());

int[] array = new int[columns];

Console.WriteLine("Введите массив через enter");
for (int i = 0; i < array.Length; i++)
{
array[i] = int.Parse(Console.ReadLine());
}

OutArray(array);