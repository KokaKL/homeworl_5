// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int random()
{
    int number = new Random().Next(0, 11);
    System.Console.Write(number + " ");
    return number;
}
int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = random();
}

int SUM(int[] array)
{
    int count = 0;   
    for (int j = 0; j < array.Length; j= j+2)
    {
        count = count + array[j];
     }
    return count;
}
int sumNum = SUM(array);
System.Console.WriteLine();
System.Console.WriteLine(sumNum);
