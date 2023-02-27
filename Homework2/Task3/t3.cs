// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
void array(int N)
{
    if (N == 6 || N == 7)
    {
        Console.WriteLine("Да.");
    }
    else
    {
        Console.WriteLine("Нет.");
    }
}
Console.Write("Введите номер дня недели: ");
int numberDay = Convert.ToInt32(Console.ReadLine());
if (numberDay > 7 || numberDay < 1)
{
    Console.WriteLine("Операция невозможна.");
    return;
}
array (numberDay);