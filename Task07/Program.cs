Console.WriteLine("Введите трехзначное число : ");
int number = Convert.ToInt32(Console.ReadLine());
int last = number % 10;// Остаток от деления 
Console.WriteLine($"Последняя цифра заданного числа: {last} ");