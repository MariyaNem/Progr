//Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму.
//Если число 1 не кратно числу 2, то программа выводит остаток от деления.
//34, 5 - не кратно, остаток 4
//16, 4 - кратно

Console.Write("Введите число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int second = Convert.ToInt32(Console.ReadLine());
//if (first%second == 0) {Console.WriteLine("кратно");}
//else { int result = first%second; Console.WriteLine($"не кратно {result}");}

bool result = first % second == 0;

if (result) Console.WriteLine("кратно");
else Console.WriteLine($"не кратно, остаток = {(first % second)}");

