// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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

bool DetectNumber (int [] array, int number)
{
    bool result = false;
    for (int i=0; i< array.Length; i++)
    {
        if (array[i] == number)
        {
            result = true;
            break;
        }
    }
    return result;
}

Console.Write("Введите число элементов массива: ");
int elemNum = Convert.ToInt32(Console.ReadLine());

int[] array = new int[elemNum];
FillArray(array);
Console.Write("Заданный массив: ");
PrintArray(array);

Console.Write("Введите число, которое требуется найти: ");
int findNum = Convert.ToInt32(Console.ReadLine());

bool yesNo = DetectNumber (array, findNum);

Console.WriteLine((yesNo)?"Это число присутствует в массиве":"Это число отсутствует в массиве");
