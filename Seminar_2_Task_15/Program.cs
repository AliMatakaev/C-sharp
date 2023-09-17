// Написать программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли он выходным.
Console.WriteLine("Введите цифру, обозначающую день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 && day < 8)
{
    if (day == 6 | day == 7)
    Console.WriteLine("Выходной");
    else
    Console.WriteLine("Рабочий день");
}
else
Console.WriteLine("Неверный ввод");
