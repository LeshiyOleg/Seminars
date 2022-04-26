/*
Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 5; b = 25 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> нет
a = -3 b = 9 -> да
*/

Console.Write("Введите два числа: ");

int numbera = Convert.ToInt32(Console.ReadLine());
int numberb = Convert.ToInt32(Console.ReadLine());

if (numbera == numberb * numberb)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}