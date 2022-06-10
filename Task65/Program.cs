/*Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/

class Program {
  public static void PrintNumbersToN(int numbFrom, int numbTo)
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



  public static void Main (string[] args)
  {
   Console.Write("Введите число M: ");
   int numberFrom = Convert.ToInt32(Console.ReadLine());
   Console.Write("Введите число N: ");
   int numberTill = Convert.ToInt32(Console.ReadLine());
   PrintNumbersToN(numberFrom, numberTill);
  }
}

