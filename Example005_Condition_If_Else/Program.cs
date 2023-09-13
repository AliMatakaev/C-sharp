Console.WriteLine("Введите ваше имя: ");
string username = Console.ReadLine();
Console.WriteLine(username);
if (username == "Маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}