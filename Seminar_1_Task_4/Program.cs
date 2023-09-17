// Написать программу, которая принимает на вход три числа, и выдает максимальное из них.

Console.WriteLine("Введите три числа: ");
int max = Convert.ToInt32(Console.ReadLine());
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

if (max < x)
{
    max = x;
}
if (max < y)
{
    max = y;
}
Console.WriteLine($"Максимальное из введенных чисел:  {max}");