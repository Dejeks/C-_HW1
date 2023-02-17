//Задача 8
Console.WriteLine("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= numb; i++)
{
    if(i % 2 == 0) {Console.WriteLine(i);}
}

