// Задача 38: Задайте массив вещественных чисел. Найдите 
// разницу между максимальным и минимальным 
// элементов массива.

//Например
// [3 7 22 2 78] -> 76

double[] SArray = GetArray(6, 100, 999);
System.Console.WriteLine(String.Join(" ", SArray));
System.Console.WriteLine($" разница = {GetDif(SArray)}");

double[] GetArray(int size, int minV, int maxV)
{
    double[] raf = new double[size];
    var random = new Random();
    for (int i = 0; i < size; i++)
    {
        raf[i] = random.Next(minV, maxV + 1) + random.NextDouble();
    }
    return raf;
}

double GetDif(double[] array)
{
    double min = array[0];
    double max = array[0];
    foreach (var item in array)
    {
        if (min > item) min = item;
        if (max < item) max = item;
    }
    return max - min;
}