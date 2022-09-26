// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];

FillArrayRandom();
PrintArray();

void FillArrayRandom()
{
    for (int i = 0; i <= array.Length - 1; i++) array[i] = new Random().Next(0, 2);
}

void PrintArray()
{
    Console.Write($"[");
    for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]},");
    Console.WriteLine($"{array[array.Length - 1]}]");
}

