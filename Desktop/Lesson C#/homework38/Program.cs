// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double [] array = {3.5, 7.1, 22.9, 2.3, 78.5};
double Max = double.MaxValue;
double Min = double.MinValue;
for (int i = 0; i < array.Length; i++)
{
    if (Max > array[i]) Max = array[i];
    if (Min < array[i]) Min = array[i];
}
string S = String.Join(",", array);
Console.WriteLine($"[{S}] --> {Max - Min}");
