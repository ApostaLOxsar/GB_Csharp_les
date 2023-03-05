// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double res(int x1, int x2, int y1, int y2, int z1, int z2) {
    double res =Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
    res = Math.Round(res, 2);
    return res;
}

Console.Write("введите x1:");
int x1 = int.Parse(Console.ReadLine());

Console.Write("введите y1:");
int y1 = int.Parse(Console.ReadLine());

Console.Write("введите z1:");
int z1 = int.Parse(Console.ReadLine());

Console.Write("введите x2:");
int x2 = int.Parse(Console.ReadLine());

Console.Write("введите y2:");
int y2 = int.Parse(Console.ReadLine());

Console.Write("введите z2:");
int z2 = int.Parse(Console.ReadLine());

double result = res(x1, x2, y1, y2, z1, z2);
Console.Write($"растояние = {result}");