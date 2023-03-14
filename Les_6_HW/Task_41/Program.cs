//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
Console.Clear();

Console.Write("Введите количество чисел: ");
int numberAmoung = int.Parse(Console.ReadLine());

int countPositivAmoung = 0;

for (int i = 0; i < numberAmoung; i++)
{
    Console.Write("Введите чисело: ");
    int number = int.Parse(Console.ReadLine());
    if (number > 0) countPositivAmoung++;
}

Console.Write($"количество чисел больше 0 = {countPositivAmoung}");