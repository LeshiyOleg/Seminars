// Задача 63: Задайте значение N. 
// Напишите программу, которая выведет все натуральные 
// числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void PrintNumbersToN(int numbFrom, int numbTo)
{
    if (numbFrom < numbTo)
    {
        Console.Write($"{numbFrom++}, ");
        PrintNumbersToN(numbFrom, numbTo);
    }
    else
    {
        Console.Write($"{numbFrom}");
    }
}

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintNumbersToN(1, number);
