﻿Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
bool not = true;
Console.WriteLine("Чётные числа от 1 до " + num);
while (i <= num)
{
if (i % 2 != 1)
{
    Console.Write(i + ", ");
    not = false;
}
    i++;
}

if (not)
{
    Console.WriteLine("Нет чётных чисел!");
}
            
    
