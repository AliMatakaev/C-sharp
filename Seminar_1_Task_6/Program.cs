// Написать программу, которая принимает на вход число, и выдает, является ли оно четным.
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 2 == 0)
{
    Console.WriteLine($"Число {n} является четным");
}
else
{
    Console.WriteLine($"Число {n} не является четным");
}