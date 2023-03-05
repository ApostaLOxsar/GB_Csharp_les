//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Вариант через числа

Console.Write("введите 5ти значное число: ");
int number = int.Parse(Console.ReadLine());

if (number > 9999 && number < 100000) 
{
    if (number % 10 == number / 10000 && number % 100 / 10 == number / 1000 % 10)
    {
         Console.Write("да");
    }
    else 
    {
         Console.Write("нет");
    }
}
else 
{
    Console.WriteLine("вы ввели не 5ти значное число");
}