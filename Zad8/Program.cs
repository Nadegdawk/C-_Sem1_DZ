// Задача 8: Напишите программу, которая на вход принимает число (N),
//           а на выходе показывает все чётные числа от 1 до N.
//           5 -> 2, 4
//           8 -> 2, 4, 6, 8

Console.WriteLine("Вывод всех четных чисел от 1 до N");
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int t = 1;

while (t <= n)
{
    if (t % 2 == 0) System.Console.Write($"{t}, ");;
    t++; 
}