// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] array = new double[10];
Random rand = new Random();

for(int i = 0; i<array.Length; i++) 
{
    array[i] = rand.Next(1, 10);
}
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"В данном массиве максимально значание - {max} , минимальное значение - {min} . Разница между максимальным и минимальным значением = {max - min}");