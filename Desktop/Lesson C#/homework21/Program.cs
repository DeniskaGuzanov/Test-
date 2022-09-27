// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = 3;
int x2 = 2;
int y1 = 6;
int y2 = 1;
int z1 = 8;
int z2 = -7;
int resultX = (x2 - x1) * (x2 - x1);
int resultY = (y2 - y1) * (y2 - y1);
int resultZ = (z2 - z1) * (z2 - z1);
int result = resultX + resultY + resultZ;
double result1 = Math.Sqrt(result);
double result2 = Math.Round(result1, 2, MidpointRounding.ToZero);

int a1 = 7;
int a2 = 1;
int b1 = -5;
int b2 = -1;
int c1 = 0;
int c2 = 9;
int resultA = (a2 - a1) * (a2 - a1);
int resultB = (b2 - b1) * (b2 - b1);
int resultC = (c2 - c1) * (c2 - c1);
int Result = resultA + resultB + resultC;
double Result1 = Math.Sqrt(Result);
double Result2 = Math.Round(Result1, 2, MidpointRounding.ToZero);
Console.WriteLine(result2);
Console.WriteLine(Result2);




