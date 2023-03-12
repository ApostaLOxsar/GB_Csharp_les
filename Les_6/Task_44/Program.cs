// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

Console.Clear();
Console.Write("Введите N: ");
int number = int.Parse(Console.ReadLine());

int x = 1;
int y = 1;
Console.Write($"0 {x} {y} ");
for (int i = 3; i < number; i++)
{
    y = x + y; //2 = 1 + 1 // 3 = 2 + 1
    x = y - x; //1 = 2 - 1 // 2 = 3 - 1
    Console.Write($"{y} ");
}
