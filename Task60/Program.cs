/*
Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
*/
int[] numbers = new int[100];
int getUniqNumber()
{
    bool uniq = false;
    int result = new int();
    while (!uniq)
    {
        result = new Random().Next(10, 100);
        if (numbers[result] == 0 )
        {
            numbers[result] = 1;
            uniq = true;
            break;
        }
        else
        {
            int countUniq = GetNumberOfUniq(numbers);
            Console.WriteLine($"Повтор {countUniq}");
            if (countUniq == 90)
            {
                Console.WriteLine("Все двухзначные числа использованы");
                break;
            }
        }
    }
    return result;
}
int GetNumberOfUniq(int[] numbers)
{
    int result = new int();
    for (var i = 0; i < numbers.GetLength(0); i++)
    {
        if (numbers[i] == 1)
        {
            result++;
        }
    }
    return result;
}
int[,,] generate3DArray(int rowsNumber, int colsNumber, int depthNumber)
{
    int[,,] result = new int[rowsNumber, colsNumber, depthNumber];
    for (var i = 0; i < rowsNumber; i++)
    {
        for (var j = 0; j < colsNumber; j++)
        {
            for (var z = 0; z < depthNumber; z++)
            {
                result[i, j, z] = getUniqNumber();
            }
        }
    }
    return result;
}

void print3DArray(int[,,] arrayToPrint, int oneLineLength = 3)
{
    int currentLength = 0;
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (var j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            for (var z = 0; z < arrayToPrint.GetLength(2); z++)
            {
                Console.Write($"[{i},{j},{z}]:{arrayToPrint[i, j,z]}\t");
                if (currentLength == oneLineLength)
                {
                    Console.WriteLine();
                    currentLength = 0;
                }
                currentLength++;
            }
        }
    }
}

const int rowsNumber = 10;
const int colsNumber = 10;
const int depthNumber = 2;
int[,,] generated3DArray = generate3DArray(rowsNumber, colsNumber, depthNumber);
print3DArray(generated3DArray,5);