//Напишите программу, которая выводит случайное тёхзначное число и удаляет вторую цифру этого числа
//456 -> 46
//782 -> 72
//918 -> 98

int number = new Random().Next(100, 999);
Console.WriteLine(number);
int first = number / 100 * 10;
int third = number % 10;
int result = third + first;
Console.WriteLine(result);