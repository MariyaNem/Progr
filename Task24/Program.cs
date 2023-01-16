// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

Console.Write("Напишите число ");
int a = Convert.ToInt32(Console.ReadLine());

int Sum(int lastNumber, int result=0)
{
    for (int i = 1; i <= lastNumber; i++)
    {
        result = result + i;
    }
    return result;
}

int res = Sum(a);
Console.WriteLine(res);