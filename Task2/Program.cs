/*
Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/

Console.Write("Введите число от 1 до 7: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("понедельник");
}
if (number == 2)
{
    Console.WriteLine("вторник");
}
if (number == 3)
{
    Console.WriteLine("среда");
}
if (number == 4)
{
    Console.WriteLine("четверг");
}
if (number == 5)
{
    Console.WriteLine("пятница");
}
if (number == 6)
{
    Console.WriteLine("суббота");
}
if (number == 7)
{
    Console.WriteLine("воскресенье");
}
else
{
    Console.WriteLine("Введите корректное число!");
}