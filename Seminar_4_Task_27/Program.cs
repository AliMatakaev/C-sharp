// Написать программу. которая принимает на вход число, и выдает сумму цифр в числе.

System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int sum = 0;

while (N > 0)
{
    sum += N % 10;
    N /= 10;
}
System.Console.WriteLine(sum);