/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и
на выходе показывает вторую цифру этого числа. */

/* Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());

int a = number1 / 10;
int b = a % 10;
Console.WriteLine($"Вторая цифра числа: {b}"); */



/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет. */

/* Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
string number1Text = Convert.ToString(number1);
if (number1Text.Length > 2){
  Console.WriteLine($"Третья цифра = {number1Text[2]}");
}
else {
  Console.WriteLine("Третьей цифры нет");
} */


/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. */

Console.Write("Введите цифру, обозначающую день недели: ");
int numberDay = Convert.ToInt32(Console.ReadLine());

if (numberDay == 6 && numberDay == 7)
{
  Console.WriteLine("Этот день является выходным");
}
else if (numberDay < 1 && numberDay > 7)
{
  Console.WriteLine("Такого дня недели нет");
}
else Console.WriteLine("Этот день не является выходным");
