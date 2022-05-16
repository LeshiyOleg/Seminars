// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    Console.Write($"Квадраты чисел от 1 до {number}: ");
    for (int i = 1; i <= number; i++)
    {
        int result = i*i;
        Console.Write (result);
        if (i <= number - 1)
        {
            Console.Write(", ");
        }
    }
}
else
{
   Console.WriteLine($"Квадраты чисел от 1 до {number}: ");
    for (int i = 1; i >= number; i = i - 1)
    {
       int result = i*i;
        Console.Write (result);
        if (i >= number + 1)
        {
            Console.Write(", ");
        }  
    }
}