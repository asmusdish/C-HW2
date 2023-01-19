﻿// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 1 || number > 7)
   {
    Console.WriteLine("Введенная цифра не является днем недели!");
    return;
   } 
if(number > 0 && number < 6)
Console.WriteLine("Введенная цифра НЕ является выходным");
if(number == 6 || number == 7)
Console.WriteLine("Введенная цифра является выходным");