//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

if (number > 99 && number < 1000) 
{
    int number_2 = (number / 10) % 10;
    Console.WriteLine($"Искомое число: {number_2}");
}
else
{
    Console.WriteLine("Вы ввели неверное число"); 
}