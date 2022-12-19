//456 - 6
//760 - 0
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>=100 && number<=999)
{
    Console.Write($"Последняя цифра в числе {number} - {number % 10}");
}
else
{
    Console.Write("Вы ввели не трёхзначное число.");
}