﻿Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num % 2 == 1)
{
    Console.WriteLine($"{num} Нечетное");
}
else
{
    Console.WriteLine($"{num} Четное");
}