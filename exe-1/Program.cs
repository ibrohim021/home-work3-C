﻿// //Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");
var numberString = Console.ReadLine();
int number = int.Parse(numberString!);

int count = 1;

while(count <= number )
{
    var qube = Math.Pow(count, 3);
    Console.WriteLine(qube);
    count++;

}

