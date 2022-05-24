// Задача 32: Напишите программу замена элементов массива: положительные 
// элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

void FillArray(int[] arrayToFill)
{
    for (int index = 0; index < arrayToFill.Length; index++)
    {
        arrayToFill[index] = new Random().Next(-9, 10);
    }
}

void PrintArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int position = 0; position < arrayToPrint.Length; position++)
    {
        if (position < arrayToPrint.Length - 1)
        {
            Console.Write($"{arrayToPrint[position]}, ");
        }
        else
        {
            Console.Write(arrayToPrint[position]);
            break;
        }
    }
    Console.Write("]");
}

void NegativeArray(int[] arrayMethod)
{
    for (int i = 0; i < arrayMethod.Length; i++)
    {
        arrayMethod[i] = arrayMethod[i] * -1;
    }
}

Console.Write("Введите число элементов массива: ");
int elemNum = Convert.ToInt32(Console.ReadLine());

int[] array = new int[elemNum];
FillArray(array);
Console.Write("Заданный массив: ");
PrintArray(array);
Console.WriteLine();
NegativeArray(array);
Console.Write("Перевернутый массив: ");
PrintArray(array);
