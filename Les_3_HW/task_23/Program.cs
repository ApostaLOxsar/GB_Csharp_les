int getcube (int a)
    {
        int cube = Convert.ToInt32(Math.Pow(a, 3));
        return cube;
    }

Console.Write("введите число: ");
int number = int.Parse(Console.ReadLine());

if (number > 0){
    for (int i = 1; i <= number; i++) 
    {
        int res = getcube(i);
        Console.WriteLine($"квадрат {i} = {res}"); // или Console.WriteLine($"квадрат {i} = {get(i)}");
    }
}
else 
    {
        Console.Write("Введенные данные не корректны");
    }