//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int Max (int arg1, int arg2, int arg3)
{
    int res = arg1; 
    if (arg2 > res) res = arg2;
    if (arg3 > res) res = arg3;
    return res;
}
int a1 = 2;
int b1 = 3;
int c1 = 7;
int max1 = Max (a1, b1, c1);    
Console.WriteLine("Максимальное число:" + max1);


int a2 = 44;
int b2 = 5;
int c2 = 78;
int max2 = Max (a2, b2, c2);    
Console.WriteLine("Максимальное число:" + max2);


int a3 = 22;
int b3 = 3;
int c3 = 9;
int max3 = Max (a3, b3, c3);    
Console.WriteLine("Максимальное число:" + max3);

