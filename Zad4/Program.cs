﻿// Задача 4: Напишите программу, которая принимает на вход три числа
//           и выдаёт максимальное из этих чисел.
//              2, 3, 7 -> 7
//              44 5 78 -> 78
//              22 3 9 -> 22

Console.WriteLine("Максимальное из трех чисел");
Console.Write("Введите первое число: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numB = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int numC = int.Parse(Console.ReadLine());

int max = numA;
if (numB > max) max = numB;
if (numC > max) max = numC;

System.Console.WriteLine($"Максимальное число: {max}");