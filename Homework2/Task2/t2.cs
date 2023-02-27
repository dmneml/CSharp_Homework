// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
int showThirdDigit(int number)
{
    int thirdDigit = 0;
    while (number > 999)
    {
        number = number / 10;
    }
    thirdDigit = number % 10;
    return thirdDigit;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number / 100 == 0)
{
    Console.WriteLine("Третьей цифры нет.");
    return;
}
int result = showThirdDigit(number);
Console.WriteLine(result);

//Очень долго мучился с этой задачей, пока не нашел метод через Digit 