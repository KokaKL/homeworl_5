// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double random()
{
    double number = new Random().Next(0, 11) + new Random().NextDouble();
    System.Console.Write(number + " ");
    return number;
}
double[] array = new double[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = random();
}

void PrintArray(double[] array, string message)
{
    Console.WriteLine(message);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

(double, double) MinMix(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return (min,max);
}
System.Console.WriteLine();
(double min, double max) = MinMix(array);
PrintArray(array, $"Минимальное = {min}, максимальное {max}");