Console.Write("Введите первое число a=");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число b=");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    Console.Write($"max={a}");
}
else
{
    Console.WriteLine($"max={b}");
}
