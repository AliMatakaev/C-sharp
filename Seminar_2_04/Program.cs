// Написать программу, принимающую на вход число, и проверяющую, 
// кратно ли оно одновременно 7 и 23

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0)
{
    System.Console.WriteLine($"Число {num} кратно 7 и 23");
}
else if (num % 7 == 0)
{
    System.Console.WriteLine($"Число {num} не кратно 23");
}
else if (num % 23 == 0)
{
    System.Console.WriteLine($"Число {num} не кратно 7");
}
else
{
    System.Console.WriteLine($"Число {num} не кратно 7 и 23");
}