
/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

/* Console.Write("Введите число: ");
string number1 = Console.ReadLine();

if (number1[0] == number1[4] && number1[1] == number1[3])
{
  Console.WriteLine($"Число {number1} является палиндромом");
}
else
{
  Console.WriteLine($"Число {number1} не является полиндромом");
} */


/* Задача 21 
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

/* Console.Write("Введите X точки A = ");
int XA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y точки A = ");
int YA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите X точки A = ");
int ZA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите X точки B = ");
int XB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y точки B = ");
int YB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y точки B = ");
int ZB = Convert.ToInt32(Console.ReadLine());

double number = Math.Sqrt((Math.Pow((XA - XB), 2)) + (Math.Pow((YA - YB), 2)) + (Math.Pow((ZA-ZB),2)));

Console.WriteLine(number); */



/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

/* Console.Write("Введите число N = ");
int N = Convert.ToInt32(Console.ReadLine());

for (int count = 1; count <= N; count++)
{
  Console.Write(Math.Pow(count, 3) + " ");
} */