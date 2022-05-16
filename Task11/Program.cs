// 11. Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int randomNumber = new Random().Next(100, 1000);

int numberOne = randomNumber / 100;
int numberTwo = (randomNumber - numberOne * 100) / 10;
int numberThree = randomNumber - numberOne * 100 - numberTwo * 10;

Console.WriteLine(randomNumber);
Console.Write(numberOne*10 + numberThree);
