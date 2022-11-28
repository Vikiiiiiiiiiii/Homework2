/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6   */

Console.WriteLine("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
string anotherNumber = Convert.ToString(number);

int length = anotherNumber.Length;

if (anotherNumber.Length > 2)
{
  Console.WriteLine("Третья цифра " + anotherNumber[2]);
}
else 
{
  Console.WriteLine("Третьей цифры нет ");
}


