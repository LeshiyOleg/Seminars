// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-10, 11);
        }
    }
}

int[,] ChangeRawsToColumns(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = i; j < matr.GetLength(1); j++)
        {
            int buf = matr[i, j];
            matr[i, j] = matr[j, i];
            matr[j, i] = buf;
        }
    }
    return matr;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int raws = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[raws, columns];
FillArray(matrix);
Console.WriteLine("Заданный двумерный массив:");
PrintArray(matrix);
Console.WriteLine();

Console.WriteLine("Измененный массив:");
ChangeRawsToColumns(matrix);
PrintArray(matrix);

