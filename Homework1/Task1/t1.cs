﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите 2 числа: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA >= numberB)
{
  Console.WriteLine("Большее число: ");
  Console.WriteLine(numberA);
}
if (numberA <= numberB)
{
  Console.WriteLine("Большее число: ");
  Console.Write(numberB);
}