// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

// int GetDiagSum(int[,] matr)
// {
//     int count = 0;
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 count = count + matr[i,j];
//             }
//         }
//     }
//     return count;
// }

int GetDiagSum(int[,] matr)
{
    int count = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        count = count + matr[i, i];
    }
    return count;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
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
Console.WriteLine($"Сумма элементов главной диагонали: {GetDiagSum(matrix)}");
