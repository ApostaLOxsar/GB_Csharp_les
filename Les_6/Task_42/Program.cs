// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

//45 -> 101101
//3  -> 11
//2  -> 10

string GetBinarCode (int temp)
{
    string result = "";
    int temp1 = 0;
    while(temp > 0)
    {
        temp1 = temp % 2;
        temp = temp / 2;
        result = temp1.ToString() + result;
    }
    return result;
}

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
string result_final = GetBinarCode (number);
Console.WriteLine(result_final);