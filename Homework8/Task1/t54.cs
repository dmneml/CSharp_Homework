// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Создать двойной массив

int[,] CreateTwoDimArray(int row, int column)
{
  return new int[row, column];
}

// Заполнение массива случайными числами

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

// Сортировка строк (по убыванию)
void SortDimArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int n = 0; n < array.GetLength(1)-1; n++)
    { 
    for (int j = 0; j < array.GetLength(1)-1; j++)
    {
      if (array[i, j] < array[i, j + 1])
      {
        int temp = array[i, j];
        array[i, j] = array[i, j + 1];
        array[i, j + 1] = temp;
      }
    }
    }
  }
}


int rows = new Random().Next(2, 10);
int columns = new Random().Next(2, 10);
int[,] userArray = CreateTwoDimArray(rows, columns);
FillTwoDimArray(userArray);
PrintDimArray(userArray);
SortDimArray(userArray);
PrintDimArray(userArray);