// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

System.Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 && num < 1000)
{
    int num2 = num / 10;
    System.Console.WriteLine($"Вторая цифра введенного числа: {num2 % 10}");
}
else
{
    System.Console.WriteLine("Неправильный ввод");
}