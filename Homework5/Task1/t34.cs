// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Ввод размера массива

int ArraySize()
{
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}

// Заполнение массива случайными числами в диапозоне

void FillArray(int [] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(100, 1000);
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

// Поиск четных чисел в массиве

int FindEvenNumbers(int [] array)
{
    int count = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] % 2 == 0) count++;
    }
    return count;
}

int [] array = new int [ArraySize()];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Количество чётных чисел в массиве: {FindEvenNumbers(array)}");
