//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6


Console.WriteLine("Введите случайное число :");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 100 )
{
    Console.WriteLine("Нет третьей цифры");
}
else
 {
    int b = int.Parse(Convert.ToString(a)[2].ToString());
  
    Console.WriteLine(b);
 }


