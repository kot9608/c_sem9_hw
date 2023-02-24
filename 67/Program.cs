/***Задача 67:**Напишите программу, 
которая будет принимать на вход число и возвращать сумму его цифр.

453 -> 12
45 -> 9*/

using System;
using static System.Console;

Clear();
Write("Введите число: ");
int st = int.Parse(ReadLine());
//int res =0;

WriteLine(PrintNumbers(st));

int PrintNumbers(int start)
{
    if (start<10)
    {
        //Console.WriteLine(start);
        return start;//"1";//start
    }

    int res = PrintNumbers(start/10) + start%10;

    //Console.WriteLine(res);
    return (res);
}