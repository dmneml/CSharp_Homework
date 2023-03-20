// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N. Выполнить с помошью рекурсии.

// Провести расчет от M и N

int CalculateSum(int min, int max)
{
  if (min == max) return max;
  if (min > max) return 0;
  else return min + CalculateSum(min + 1, max);
}

int n = 1;
int m = 10;
Console.WriteLine($"Сумма чисел от {n} до {m}: {CalculateSum(n, m)}.");