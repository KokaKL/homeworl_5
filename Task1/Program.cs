// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int random()
{
    int number = new Random().Next(100, 1000);
    System.Console.Write(number + " ");
    return number;
}

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = random();
}

int Check(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 ==0)
        {
            count = count + 1;
        }
    }
    return count;
}

int CheckArray = Check(array);
System.Console.WriteLine();
System.Console.WriteLine(CheckArray);