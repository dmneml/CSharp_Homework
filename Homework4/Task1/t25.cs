// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// нельзя использовать Math.Pow


// Функция ввода числа
int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция возведения в степень
void Degree(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    Console.WriteLine(result);
}

int numberA = GetNumber("Введите число A: ");
int numberB = GetNumber("Введите число B: ");
Degree(numberA, numberB);