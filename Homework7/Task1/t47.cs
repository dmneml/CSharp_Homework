// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Создать пустой Двойной массив по заданным параметрам

double[,] CreateTwoDimArray(int row = 3, int column = 4)
{
  return new double[row, column];
}
// Создание отрицательного числа

bool DoNegative()
{
  int number = new Random().Next(100);
  if (number > 50) return true;
  else return false;
}

// Заполнить матрицу случайными значениями

void FillTwoDimArray(double[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      bool k = DoNegative();
      if (k)
      {
        matr[i, j] = Math.Round(new Random().NextDouble() * 10 * -1, 1);
        if (matr[i, j] == 0)
        {
          matr[i, j] = 0;
        }
      }
      else
      {
        matr[i, j] = Math.Round(new Random().NextDouble() * 10, 1);
      }
    }
  }
}

// Печать матрицы

void PrintDimArray(double[,] array)
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

double[,] newDimArray = CreateTwoDimArray();
FillTwoDimArray(newDimArray);
PrintDimArray(newDimArray);
