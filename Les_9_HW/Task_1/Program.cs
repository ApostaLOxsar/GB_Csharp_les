//Задача 1: Задайте значение N. Напишите программу, которая выведет все четные натуральные числа в промежутке от m до N . Выполнить с помощью рекурсии.


void PrintEvenNumbers(int m, int n)
{
    if (m % 2 != 0) m += 1;
    if (m > n) return;
    if (m != 0) Console.Write(m + "  ");
    PrintEvenNumbers(m + 2, n);
}

Console.Clear();

Console.WriteLine("Введите M: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine();

if (n >= m) PrintEvenNumbers(m, n);
else PrintEvenNumbers(n, m);