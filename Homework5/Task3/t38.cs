// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

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

// Поиск минимального значения массива

int FindMin(int[] array)
{
    int min = array[0];
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] < min) min = array[index];
    }
    return min;
}

// Поиск максимального значения массива

int FindMax(int[] array)
{
    int max = array[0];
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] > max) max = array[index];
    }
    return max;
}

int [] array = new int [ArraySize()];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Наибольшее число: {FindMax(array)}, наименьшее: {FindMin(array)}");
Console.WriteLine($"Разница значений: {FindMax(array) - FindMin(array)}");
