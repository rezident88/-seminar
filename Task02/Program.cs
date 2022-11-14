Console.WriteLine("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
if(numA > numB)
{
    Console.WriteLine($"Наибольшее число  {numA}");
    Console.WriteLine($"Наименьшее число  {numB}");
}
else
{
    Console.WriteLine($"Наибольшее число  {numB}");
    Console.WriteLine($"Наименьшее число  {numA}");
}