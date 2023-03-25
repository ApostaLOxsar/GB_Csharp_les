// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Clear();

Console.WriteLine("Введите M: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine();


int GetFunctionAcerman(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0)
        return GetFunctionAcerman(n - 1, 1);
    else
        return GetFunctionAcerman(n - 1, (GetFunctionAcerman(n, m - 1)));
}

if (m >= 0 && n >= 0)
    Console.WriteLine($"A({m}, {n}) = {GetFunctionAcerman(m, n)}");
else Console.WriteLine("одно из значений некоректно < 0");