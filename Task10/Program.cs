//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
using System;
using static System.Console;
Console.Clear();
int number = new Random().Next(100, 1000);
Write($"{number} -> {((number/10)%10)}");
