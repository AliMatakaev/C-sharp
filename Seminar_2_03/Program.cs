// Написать программу, которая будет принимать на вход два числа, и выводить, 
// является ли второе число кратным первому. Если нет, то программа выводит
// остаток от деления.
Console.WriteLine("Введите два числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 % num1 == 0)
{
    System.Console.WriteLine($"Число {num2} кратно {num1}");
}
else
{
    System.Console.WriteLine($"Число {num2} не кратно {num1}, остаток от деления {num2 % num1}");
}
