Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = -number;
if(number >= 0)
{
    while (count <= number)
{
    Console.WriteLine(count);
    count++;
}
}
else
{
    while (count >= number)
    {
        Console.WriteLine(count);
        count--;
    }
}
