// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

// Функция ввода сообщения
int NameInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = NameInt("Введите число N: ");

for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{i*i*i} ");
}
