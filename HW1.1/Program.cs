//Задача 4

Console.WriteLine("Введите 1ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3ое число: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 3ое число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a >= b & a >= c)
{
    Console.WriteLine(a);
}
else if (b >= a & b >= c)
{
    Console.WriteLine(b);
}
else
    Console.WriteLine(c);
