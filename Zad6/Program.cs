// Задача 6: Напишите программу, которая на вход принимает число
//           и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//           4 -> да
//          -3 -> нет
//           7 -> нет

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (Math.Abs(num % 2) == 1)
{
    System.Console.WriteLine("Число нечетное");
}
else {
    System.Console.WriteLine("Число четное");
}