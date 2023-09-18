// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int n = num.ToString().Length;
if (n < 3)
{
    System.Console.WriteLine("Третьей цифры в числе нет");
}

else if (n == 3)
{
    System.Console.WriteLine($"Третья цифра введенного числа: {num % 10}");
}
else
{
    System.Console.WriteLine($"Третья цифра введенного числа: {num / Convert.ToInt32(Math.Pow(10, n-3)) % 10}");
}

