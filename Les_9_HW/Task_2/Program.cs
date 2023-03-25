//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int GetSumElement(int m, int n)
{
    if (m > n) return 0;
    return m + GetSumElement(m + 1, n);
}

Console.Clear();

Console.WriteLine("Введите M: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine();

int result = 0;
if (n >= m) result = GetSumElement(m, n);
else result = GetSumElement(n, m);

Console.WriteLine($"Сумма от {m} до {n} = {result}");