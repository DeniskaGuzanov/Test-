int [,] array = new int [3, 3];
void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
         arr[i, j] = new Random().Next(-10, 10);       
         Console.Write($"{arr[i, j]}, ");
        }
        Console.WriteLine(); 
    }
}   
PrintArr(array);
