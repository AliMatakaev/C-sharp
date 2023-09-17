// Напишите программу, которая выводит случайное число из отрезка от 10 до 99,
// и показывает наибольшую цифру этого числа.
int num = new Random().Next(10, 100);
int num1 = num / 10;
int num2 = num % 10;
if (num1 > num2)
Console.WriteLine($"Наибольшая цифра числа {num}: {num1}");
else
Console.WriteLine($"Наибольшая цифра числа {num}: {num2}");
