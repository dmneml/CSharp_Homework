// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Создание двумерного массива

int[,] CreateTwoDimArray(int row, int column)
{
  return new int[row, column];
}

// Автоматическое заполнение массива

void FillTwoDimArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
}

// Печать массива

void PrintDimArray(int[,] array)
{
  Console.WriteLine(" ");
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($" {array[i, j]} ");
    }
    Console.WriteLine(" ");
  }
}

// Расчёт среднее арифметическое 

void CalculateArithmeticMean(int[,] array)
{
  double result = 0;
  for (int j = 0; j < array.GetLength(1); j++)
  {
    for (int i = 0; i < array.GetLength(0); i++)
    {
      result += array[i, j];
    }
    result = Math.Round(result / (array.GetLength(0)), 2);
    Console.WriteLine($"Среднее арифметическое {j + 1} колонки: {result}.");
    result = 0;
  }
}

int rows = 3;
int columns = 4;
int[,] userTwoDimArray = CreateTwoDimArray(rows, columns);
FillTwoDimArray(userTwoDimArray);
PrintDimArray(userTwoDimArray);
CalculateArithmeticMean(userTwoDimArray);


