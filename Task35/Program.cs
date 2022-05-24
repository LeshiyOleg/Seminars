// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат
//  в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении
//  сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void FillArray(int[] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index] = new Random().Next(-1000, 1000);
    }
}

void PrintArray(int[] col)
{
    Console.Write("[");
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
    Console.WriteLine("]");
}

int FindAmountInDiapason(int[] array, int from, int to)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= from && array[i] <= to)
        {
            count = count + 1;
        }
    }
    return count;
}

Console.Write("Введите число элементов массива: ");
int elemNum = Convert.ToInt32(Console.ReadLine());

int[] array = new int[elemNum];
FillArray(array);
Console.Write("Заданный массив: ");
PrintArray(array);

int amount = FindAmountInDiapason(array, 10, 99);

Console.Write($"Количество чисел из диапазона: {amount}");
