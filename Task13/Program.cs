// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
using System;
using static System.Console;
Console.Clear();
WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
string str = a.ToString();
int[] b = new int[str.Length];
int len = str.Length;
for( int i=0; i< str.Length; i++)
{
     b[i] = int.Parse(str[i].ToString());
}
if(len>=3) WriteLine(b[2]);
if(len<3) WriteLine("Третьей цифры нет");