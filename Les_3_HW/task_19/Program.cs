//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Вариант через строки

Console.Write("введите 5ти значное число: ");
string number = Console.ReadLine();

if (int.Parse(number) > 9999 && int.Parse(number) < 100000) 
{
    if (number[0] == number[4] && number[1] == number[3])
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
    Console.Write("вы ввели не 5ти значное число");
}