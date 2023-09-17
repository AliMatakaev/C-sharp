// Написать программу, которая на вход принимает число N, и выдает все четные числа от 1 до N.
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = 2;
while (result <= n)
{
    Console.Write($"{result}, ");
    result = result + 2;
}
