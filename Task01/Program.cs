Console.Write("Введите квадрат числа: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB*numberB == numberA)
{
    Console.Write($"{numberA} является квадратом {numberB}");
}
else
{
    Console.Write($"{numberA} не является квадратом {numberB}");
}