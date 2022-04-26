/*
5. Напишите программу вычисления значения 
функции возведения числа в квадрат.
4 -> 16
-3 -> 9 
-7 -> 49 
*/

Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

int result = number * number;

Console.WriteLine(result);
