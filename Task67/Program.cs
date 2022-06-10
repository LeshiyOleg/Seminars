// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int GetSumOfNumbers(int numbToCount)
// {
//     int numberSum = 0;
//     if (numbToCount > 0)
//     {
//         numberSum = numberSum + numbToCount % 10;
//         numbToCount = numbToCount / 10;
//         GetSumOfNumbers(numbToCount / 10);
//     }
//     else
//     {
//         numberSum = numberSum + numbToCount % 10;
//     }
//     return numberSum;
// }

int GetSumOfNumbers(int numbToCount)
{
    if(numbToCount==0)
    {
        return 0;
    }
    return numbToCount%10+GetSumOfNumbers(numbToCount/10);
} 

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = GetSumOfNumbers(number);
Console.Write($"Сумма цифр в числе {number} равняется {sum}");