// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Вариант 1 (через String)
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// number = Math.Abs(number);
// string numberStr = Convert.ToString(number);
// int digitsNum = numberStr.Length;
// Console.WriteLine($"Количество цифр в числе {digitsNum}");

// Вариант 2 (через цикл FOR)
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// number = Math.Abs(number);
// int digitsNum = 1;
// for (int i=10; number >= 10;)
// {
//     number = number / i;
//     digitsNum = digitsNum + 1; 
// }
// Console.WriteLine($"Количество цифр в числе {digitsNum}");

// Вариант 3 (через цикл WHILE)
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
int digitsNum = 1;
while (number >= 10)
{
    int i = 10;
    number = number / i;
    digitsNum = digitsNum + 1; 
}
Console.WriteLine($"Количество цифр в числе {digitsNum}");