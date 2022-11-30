Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
if ((a / 10000) == (a % 10))
{
    a = (a / 10) % 1000;
    if ((a / 100) == (a % 10))
    {
        Console.WriteLine($"Полиндром");
    }
    else
    {
        Console.WriteLine("Не полиндром");
    }
}
else
{
    Console.WriteLine("Не полиндром");
}