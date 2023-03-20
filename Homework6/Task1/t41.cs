// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Определение количества чисел для ввода

int GetIntNumber(string text)
{
  Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());
}

// Заполнение массива пользователем

int[] UserNumbers(int sizeNum)
{
  int[] numbers = new int[sizeNum];
  for (int i = 0; i < sizeNum; i++)
  {
    numbers[i] = GetIntNumber($"Введите {i + 1} число: ");
  }
  return numbers;
}

// Проверка числа на условие задачи

int CheckAndCount(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0)
    {
      count++;
    }
  }
  return count;
}


int size = GetIntNumber("Введите количесво чисел: ");
int[] userNumbers = UserNumbers(size);
Console.WriteLine($"Количество чисел в массиве, больше 0: {CheckAndCount(userNumbers)}.");