Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
if (B == 0) System.Console.WriteLine(1);
else
{
    int result = A;
for (int i = 1; i < B; i++)
{
   result = result * A; 
}
System.Console.WriteLine(result);
}
