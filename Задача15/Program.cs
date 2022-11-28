/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет   */

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int numberDay = Convert.ToInt32(Console.ReadLine());
string numberStr = Convert.ToString(numberDay);

if (numberDay == 6 || numberDay == 7) 
{
  Console.WriteLine("Выходной день");
}
else 
     if (numberDay < 1 || numberDay > 7) 
  {
    Console.WriteLine("Не соответствует дню недели");
  }
else
    Console.WriteLine("Этот день не выходной");


