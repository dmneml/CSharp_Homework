// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// Высчитать результат (через рекурсию)
string PrintNumbers(int num)
{
  if (num == 1) return "1";
  else return num + ", " + PrintNumbers(num-1);
}

int n = 10;
Console.WriteLine($"Натуральные числа от {n} до 1: {PrintNumbers(n)}.");