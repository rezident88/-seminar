﻿int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 --> {number}");

// int firstDigit = number / 10; // 7
// int secondDigit = number % 10; // 8

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа --> {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа --> {secondDigit}");

int MaxDigit(int num) // int num = number
{
    int firstDigit = num / 10; // 7
    int secondDigit = num % 10; // 8
    // if (firstDigit > secondDigit)
    //     return firstDigit;
    //     return secondDigit;

    return  firstDigit > secondDigit ? firstDigit : secondDigit; //если условие выполняется то выдает результат переменной после вопроса если не выполняется то послу двоеточия
    
}

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа --> {maxDigit}");
