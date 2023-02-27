// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = N/100;
int c = N%10;
int b = (N - a*100 - c)/10;
Console.WriteLine(b);