// // Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите два числа:");
int numberOne = Convert.ToInt32(Console.ReadLine());
int numberTwo = Convert.ToInt32(Console.ReadLine());
if (numberOne % numberTwo != 0)
{
    Console.WriteLine("Число " + numberOne + " не кратно " + numberTwo);
    Console.WriteLine("остаток " + numberOne % numberTwo);
}
else
{
    Console.WriteLine("Число " + numberOne + " кратно " + numberTwo);
}