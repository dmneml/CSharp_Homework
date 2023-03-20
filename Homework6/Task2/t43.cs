// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Заполнение размера массива

double GetIntNumber(string text)
  {
    Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
  }

// Создание массива

double[] CreateIntArray()
  {
    return new double[4];
  }

// Ввод значений пользователем

void FillByUserNumbersArray(string[]text, double[]numbers)
{
  Console.WriteLine("Ввод значения: ");
  for (int i = 0; i < text.Length; i++)
  {
  numbers[i] = GetIntNumber(text[i]);
  }
}

// Расчет X

double CalculationX(double[]array)
{
  double result = Math.Round(Convert.ToDouble((array[2]-array[0])/(array[1]-array[3])),1);
  return result;
}
// Расчет Y

double CalculationY(double num, double[] array)
{
  double result = Math.Round(Convert.ToDouble(array[1]*num+array[0]),1);
  return result;
}

Console.WriteLine ("Нахождение точки пересечения двух прямых, заданных уравнениями: ");
Console.WriteLine ("y = k1 * x + b1 и y = k2 * x + b2.");
string[] variables = new string[4] {"b1 = ","k1 = ","b2 = ","k2 = "};
double [] userNumbers = CreateIntArray();
FillByUserNumbersArray (variables, userNumbers);
double piercingX = CalculationX(userNumbers);
double piercingY = CalculationY(piercingX, userNumbers);
Console.WriteLine ($"Точка пересечения: ({piercingX}, {piercingY}).");
