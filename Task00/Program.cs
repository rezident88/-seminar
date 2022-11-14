Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine()); // Конвертация текста в число
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");