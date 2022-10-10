// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет


Console.WriteLine("Введите позицию элемента в строке --> n");
int pos1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемента в стоблце --> m");
int pos2 = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [3, 4];
void PrintArray ( int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
         {
            arr [i, j] = new Random().Next(-10, 10);
            Console.Write($"{arr[i, j]}, ");
         }
        Console.WriteLine();
    }
    if(pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
    {
        Console.WriteLine("Такого элемента с позицией (pos1, pos2) --> не существует");
    }  
}
PrintArray(array);





