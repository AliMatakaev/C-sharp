// Написать программу, которая принимает на вход два числа, 
// и выдает, какое число больше, а какое меньше

Console.WriteLine("Введите два числа: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
if (m > n)
{
    Console.WriteLine($"Число {m} больше, чем число {n}");
}
else Console.WriteLine($"Число {n} больше, чем число {m}");
