// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Вариант 1 (через цикл FOR)
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// if (number > 0)
// {
//     for (int i = 1; i <= number; i++)
//     {
//         result = result * i;
//     }
//     Console.WriteLine($"Произведение всех чисел от 1 до {number} = {result}");
// }
// else 
// {
//     Console.WriteLine($"Произведение всех чисел от 1 до {number} = 0");
// }

// Вариант 1 (через цикл WHILE)
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 1;
if (number > 0)
{
    int i = 1;
    while (i <= number)
    {
        result = result * i;
        i++;
    }
    Console.WriteLine($"Произведение всех чисел от 1 до {number} = {result}");
}
else
{
    Console.WriteLine($"Произведение всех чисел от 1 до {number} = 0");
}