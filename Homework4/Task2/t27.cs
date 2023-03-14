// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.


// Функция ввода
int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция подсчёта суммы
int GetResult(int number)
{
    int result = 0;
    while (number > 0)
    {
        int lastDigit = number % 10;
        result = result + lastDigit;
        number /= 10;
    }
    return result;
}

int number = GetNumber("Введите число: ");
int result = GetResult(number);
Console.WriteLine(result);