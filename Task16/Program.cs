﻿// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет


Console.WriteLine("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int num2 = Convert.ToInt32(Console.ReadLine());

bool Square(int number1, int number2)
{
    return(number1 == number2 * number2) || (number2 == number1 * number1);  //    || оператор либо 
}
Console.WriteLine(Square(num1, num2) ? "Да" : "Нет");