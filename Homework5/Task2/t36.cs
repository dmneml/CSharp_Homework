// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// Ввод размера массива

int ArraySize()
{
    Console.Write("Введите размер вашего массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}

// Заполнение массива случайными числами в диапозоне

void FillArray(int [] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(1, 101);
    }
}

// Печать массива

void PrintArray(int [] array)
{
    for(int index = 0; index < array.Length; index++)
    {
        Console.Write($"{array[index]} ");
    }
    Console.WriteLine();
}

// Поиск нечётных позиций, подсчёт их суммы

int SumOdd (int [] array)
{
    int sum = 0;
    int index = 0;
    if (array.Length == 1)
    {
        return array[0];
    }
    else
    {
        while (index < array.Length)
        {
            sum = sum + array[index];
            index = index + 2;
        }
    }
    return sum;
}

int [] array = new int [ArraySize()];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Сумма чисел на нечётной позиции равна: {SumOdd(array)}.");
