// Задача 36: Задайте одномерный массив, заполненный 
//случайными числами. Найдите сумму элементов, стоящих 
//на нечётных позициях.
// Например
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] SArray = GetArray(6,100,999);
System.Console.WriteLine(String.Join(" ", SArray));
System.Console.WriteLine($" Сумма элементов на нечет. позициях = {GetSum(SArray)}");

int[] GetArray(int size, int minV, int maxV)
{
    int[] raf = new int[size];

    for (int i = 0; i < size; i++)
    {
        raf[i] = new Random().Next(minV, maxV + 1);
    }
    return raf;
}

int GetSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 1) sum += array[i];
}
return sum;
}