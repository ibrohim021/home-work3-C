// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите значение х1");
var x1String = Console.ReadLine();
int x1 = int.Parse(x1String!);

Console.WriteLine("Введите значение y1");
var y1String = Console.ReadLine();
int y1 = int.Parse(y1String!);

Console.WriteLine("Введите значение х2");
var x2String = Console.ReadLine();
int x2 = int.Parse(x2String!);

Console.WriteLine("Введите значение y2");
var y2String = Console.ReadLine();
int y2 = int.Parse(y2String!);

Console.WriteLine("Введите значение z1");
var z1String = Console.ReadLine();
int z1 = int.Parse(x2String!);

Console.WriteLine("Введите значение z2");
var z2String = Console.ReadLine();
int z2 = int.Parse(y2String!);

double AB = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));

Console.WriteLine("Растояние = " +AB.ToString("N2"));