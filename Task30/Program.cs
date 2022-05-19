// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(0, 2);
//         index++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     Console.Write("Случайный массив: [");
//     while (position < count)
//     {
//         if (position < count - 1)
//         {
//             Console.Write($"{col[position]}, ");
//             position++;
//         }
//         else
//         {
//             Console.Write(col[position]);
//             break;
//         }
//     }
//     Console.Write("]");
// }

// Функции через цикл FOR

void FillArray(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] col)
{
    Console.Write("Случайный массив: [");
    for (int position = 0; position < col.Length; position++)
    {
        if (position < col.Length - 1)
        {
            Console.Write($"{col[position]}, ");
        }
        else
        {
            Console.Write(col[position]);
            break;
        }
    }
    Console.Write("]");
}

Console.Write("Введите число элементов массива: ");
int elemNum = Convert.ToInt32(Console.ReadLine());

int[] array = new int[elemNum];

FillArray(array);
PrintArray(array);
Console.WriteLine();

