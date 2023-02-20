/* Задача 10: 
Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.*/

int numb = 0;

while (true)
{
    numb = Convert.ToInt32(Console.ReadLine());
    if (numb % 1000 == numb & numb % 100 != numb) //Условие 3х значности
    {
        numb /= 10;
        Console.WriteLine(numb % 10);
    }
    else{Console.WriteLine("Введите 3х значеной число!");}
    
}