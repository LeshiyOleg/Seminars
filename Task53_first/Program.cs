int[,] GenerateArray(int colLength, int rowLength, int minBorder = 0, int maxBorder = 20)
{
    if (minBorder > maxBorder)
    {
        Console.WriteLine($"Границы генерации не верны, минимальный больше максимального, minBorder: {minBorder}, maxBorder: {maxBorder}");
        int buf = minBorder;
        minBorder = maxBorder;
        maxBorder = buf;
    }
    int[,] generatedArray = new int[colLength, rowLength];
    for (var i = 0; i < colLength; i++)
    {
        for (var j = 0; j < rowLength; j++)
        {
            generatedArray[i, j] = new Random().Next(minBorder, maxBorder + 1);
        }
    }
    return generatedArray;
}

void PrintHeadOfNumbers(int length, string name = "")
{
    if (!string.IsNullOrEmpty(name))
    {
        Console.WriteLine($"--------------{name}--------------");
    }
    Console.Write("[ ]\t");
    for (var i = 0; i < length; i++)
    {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine();
}

void Print2DArray(int[,] arrayToPrint, string name = "")
{
    PrintHeadOfNumbers(arrayToPrint.GetLength(1), name);
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void PrintArray(int[] array, string name = "")
{
    PrintHeadOfNumbers(array.Length, name);
    Console.Write("[ ]\t");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
}

int[] getRowFrom2DArray(int[,] twoDArray, int rowIndex)
{
    int[] result = new int[twoDArray.GetLength(1)];

    for (var i = 0; i < twoDArray.GetLength(1); i++)
    {
        result[i] = twoDArray[rowIndex, i];
    }
    return result;
}

int[,] generatedArray = GenerateArray(7, 5, maxBorder: 100, minBorder: 20);
Print2DArray(generatedArray, "Двухмерный массив");
const int rowIndex = 2;
int[] oneRow = getRowFrom2DArray(generatedArray, rowIndex);
PrintArray(oneRow, $"Строка двухмерного массива № {rowIndex}");