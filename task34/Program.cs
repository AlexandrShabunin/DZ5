//Задача 34: Задайте массив заполненный случайными 
//положительными трёхзначными числами. Напишите 
//программу, которая покажет количество чётных чисел в 
//массиве.

//например [345, 897, 568, 234] -> 2

int[] SArray = GetArray(6,100,999);
System.Console.WriteLine(String.Join(" ", SArray));
System.Console.WriteLine($" Колличество четных элементов в массиве = {GetEvenCount(SArray)}");

int[] GetArray(int size, int minV, int maxV)
{
    int[] raf = new int[size];

    for (int i = 0; i < size; i++)
    {
        raf[i] = new Random().Next(minV, maxV + 1);
    }
    return raf;
}

int GetEvenCount(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0) count++;
    }
    return count;
}