/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B */

/* Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write((Math.Pow(A, B))); */



/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
452 -> 11
82 -> 10
9012 -> 12 */

/* Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = Convert.ToString(number).Length;
int number1 = 0;
int result = 0;

for (int i = 0; i < count; i++)
{
  number1 = number - number%10;
  result = result + (number-number1);
  number=number/10;
}
Console.WriteLine($"Сумма цифр в числе: {result}"); */



/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. */

/* int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
  array[i] = new Random().Next(0, 20);
  Console.Write(array[i] + " ");
} */