﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизнчное число");

var number = Console.ReadLine();


if (number!.Length > 5 || number!.Length < 5){
  Console.WriteLine("Введите пятизначное число !!!");
  return;
}


if(number[0] == number[4] || number[1] == number[3])
{
    Console.WriteLine("Это полиндром");
}

else
{
     Console.WriteLine("Это не полиндром");
}


