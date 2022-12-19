Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int negative = number*-1;
while (number >= negative)
{
    Console.Write(negative + " ");
    negative++;
}