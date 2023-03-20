// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Создать Двумерный массив

int[,] CreateTwoDimArray(int row, int column)
{
  return new int[row, column];
}

// Заполнить массив автоматически

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

// Ввод желаемого числа

int GetIntNumber(string text)
{
  int value = 0;
  bool flag = false;
  while(!flag)
  {
  Console.WriteLine(text);
  flag = int.TryParse(Console.ReadLine(), out value);
  }
  return value;
}

// Печать матрицы

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

// Проверка заданного условия

void CheckUserDataPrint(int[,] array, int row, int column)
{
  if (row <= array.GetLength(0) && column <= array.GetLength(1))
  {
  Console.WriteLine($"Номер в координатах [{row},{column}]: {array[row-1,column-1]}.");
  }
  else
  {
  Console.WriteLine($"Нет числа на координатах [{row},{column}].");
  }
}


int rows = new Random().Next(2,11);
int columns = new Random().Next(2,11);
int[,] newDimArray = CreateTwoDimArray(rows,columns);
FillTwoDimArray(newDimArray);
PrintDimArray(newDimArray);
int userCheckRow = GetIntNumber("Ввод строки для проверки: ");
int userCheckColumn = GetIntNumber("Ввод числа для проверки: ");
CheckUserDataPrint(newDimArray, userCheckRow, userCheckColumn);
