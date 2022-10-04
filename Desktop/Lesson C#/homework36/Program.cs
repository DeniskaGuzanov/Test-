// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int [] array = new int [5];
Random rnd = new Random();

int sum = 0; 
 for (int i = 0; i < array.Length; i++)
 {
    array[i] = rnd.Next(-10, 10);
    if(i % 2 != 0 ) sum = sum + array [i];
 }
 
 string S = String.Join(",", array);
 Console.WriteLine ($"[{S}] Сумма элементов =  {sum} ");
