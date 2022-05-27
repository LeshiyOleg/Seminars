// Задача 40: Напишите программу, которая принимает 
// на вход три числа и проверяет, может ли существовать 
// треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона 
// треугольника меньше суммы двух других сторон.

bool CheckPossibility(int first, int second, int third)
{
    bool result = true;
    if (first >= second + third) 
    {
        result = false;
    }
    if (second >= first+third)
    {
        result = false;
    }
    if (third >= first+second)
    {
        result = false;
    }
    return result;
}

Console.Write("Введите первую длину: ");
int firstSide = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую длину: ");
int secondSide = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью длину: ");
int thirdtSide = Convert.ToInt32(Console.ReadLine());

bool check = CheckPossibility(firstSide, secondSide, thirdtSide);

if (check == true)
{
    Console.WriteLine($"Треугольник со сторонами {firstSide}, {secondSide} и {thirdtSide} может существовать");
}
else
{
    Console.WriteLine($"Треугольник со сторонами {firstSide}, {secondSide} и {thirdtSide} существовать НЕ может");
}