// Задача 70: Напишите программу, которая на вход принимает 
// два числа и выдаёт первые N чисел, для которых 
// каждое следующее равно сумме двух предыдущих. 
// 3 и 4, N = 5 -> 3 4 7 11 18
// 6 и 10, N = 4 -> 6 10 16 26 

Console.WriteLine("Введите 2 числа:");
int numberOne = Convert.ToInt32(Console.ReadLine());
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте длину ряда: ");
int temp = Convert.ToInt32(Console.ReadLine());

int[] SumNumber(int numberOne, int numberTwo, int temp)
{
    int[] result = new int[temp];
    result[0] = numberOne;
    result[1] = numberTwo;
    for (var i = 2; i < result.Length; i++)
    {
        result[i] = result[i - 1] + result[i - 2];
    }
    return result;
}
void PrintArray(int[] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write(" " + arrayToPrint[i] + " ");
    }
}
int[] result = SumNumber(numberOne, numberTwo, temp);
System.Console.Write($"{numberOne} и {numberTwo}, N = {temp} - >");
PrintArray(result);