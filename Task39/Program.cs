// Задача 39: Напишите программу, которая перевернёт 
// одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


double[] GenerateArray(int length, int lowerBorder, int upperBorder)
{
    double[] result = new double[length];
    for (var i = 0; i < length; i++)
    {
    result[i] = new Random().NextDouble() * upperBorder + lowerBorder;
}
return result;
}

void PrintArray(double[] arrayToPrint, string name = "")
{
    Console.ForegroundColor = ConsoleColor.Green;

    if (!string.IsNullOrEmpty(name))
    {
        Console.WriteLine($"Массив {name}");
    }
    Console.WriteLine("----------------------------------------------");
    Console.ForegroundColor = ConsoleColor.White;

    Console.Write("[");
    for (var i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(Math.Round(arrayToPrint[i],2));
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine();
}

double[] ReverseArray(double[] arrayToReverse)
{
    double[] result = new double[arrayToReverse.Length];
    for (var i = 0; i < arrayToReverse.Length; i++)
    {
        result[i] = arrayToReverse[arrayToReverse.Length - 1 - i];
    }
    return result;
}


Console.Clear();
double[] arrayToPrint = GenerateArray(10, -50, 100);
PrintArray(arrayToPrint, "Начальный");

double[] reversedArray = ReverseArray(arrayToPrint);
PrintArray(reversedArray, "Перевернутый");