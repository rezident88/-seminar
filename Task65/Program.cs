// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.

Console.WriteLine("Введите первое натуральное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

void NumbersMTon(int numb1, int numb2)
{
    if (numb1 > numb2)
    {
        NumbersMTon(numb1 , numb2 + 1);
        Console.Write($"{numb2} ");
    }
    if (numb1 < numb2)
    {
        Console.Write($"{numb1} ");
        NumbersMTon(numb1 + 1 , numb2);
    }
    if (numb1 == numb2)
    Console.Write($"{numb1} ");
}

NumbersMTon(numberM, numberN);