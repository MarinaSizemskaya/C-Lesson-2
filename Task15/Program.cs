// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
using System;
using static System.Console;
Console.Clear();
WriteLine("Введите номер дня недели: ");
int a = int.Parse(Console.ReadLine());
if(a==6 || a==7) WriteLine("Выходной");
if(1<=a && a<=5) WriteLine("Будний");
if(a>7 || a<1) WriteLine("Введен неправильный номер");