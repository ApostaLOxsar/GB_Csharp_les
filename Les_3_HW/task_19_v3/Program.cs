//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Вариант с переворотом для любого числа

bool getpalind(int num)
{
    int n = num;
    int rev = 0;
 
    while (n != 0)
    {
        int r = n % 10;
        rev = rev * 10 + r;
        n = n / 10;
    }

    return (num == rev);
}

Console.Write("введите число: ");
int number = int.Parse(Console.ReadLine());
 
if (getpalind(number))
    {
         Console.Write("да");
    }
    else 
    {
         Console.Write("нет");
    }
