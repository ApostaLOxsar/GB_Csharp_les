// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int numberN = int.Parse(Console.ReadLine()),
    i = 2;
while (i <= numberN) {
Console.Write($"{i} ");
i += 2;
}