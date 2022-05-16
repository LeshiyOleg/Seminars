// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки А:");
Console.WriteLine("Введите координату X точки А");
int XpointA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А");
int YpointA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");
Console.WriteLine("Введите координату X точки B");
int XpointB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B");
int YpointB = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((XpointA - XpointB) * (XpointA - XpointB) + (YpointA - YpointB) * (YpointA - YpointB));

Console.WriteLine("Расстояние между точками A и B равняется: " + Math.Round(result, 2));