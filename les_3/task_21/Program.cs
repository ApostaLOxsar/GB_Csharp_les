double res(int x1, int x2, int y1, int y2) {
    double res = Math.Round(Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1)), 2);
    return res;
}

Console.Write("введите x1:");
int x1 = int.Parse(Console.ReadLine());

Console.Write("введите y1:");
int y1 = int.Parse(Console.ReadLine());

Console.Write("введите x2:");
int x2 = int.Parse(Console.ReadLine());

Console.Write("введите y2:");
int y2 = int.Parse(Console.ReadLine());

//double result = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1));
//Console.Write($"растояние = {result}");
double result = res(x1, x2, y1, y2);
Console.Write($"растояние = {result}");