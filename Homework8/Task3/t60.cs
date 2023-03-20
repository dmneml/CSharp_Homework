// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

// Печать трехмерного массива

void PrintThreeDimArray(int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int l = 0; l < array.GetLength(2); l++)
      {
        Console.Write($"{array[i, j, l]} ({i},{j},{l}) ");
      }
      Console.WriteLine();
    }
  }
}

// Решение:

int[,,] ThreeDimArray = new int[2, 2, 2]
{
  {             // страница книги с индексом 0
    {66, 27},   // строка и столбец на страницу книги с индексом 0
    {25, 90}
  },
  {             // страница книги с индексом 1
    {34, 26},
    {41, 55}
  }
};
PrintThreeDimArray(ThreeDimArray);
