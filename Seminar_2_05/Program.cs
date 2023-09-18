// Написать программу, которая принимает два числа, и проверяет, 
//является ли одно число квадратом другого.

Console.WriteLine("Введите два числа: ");

int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());

if (n * n == m)
{
    System.Console.WriteLine($"{m} является квадратом {n}");
}
else if (m * m == n)
{
    System.Console.WriteLine($"{n} является квадратом {m}");
}
else
{
    System.Console.WriteLine("Нет");
}