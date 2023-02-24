// **Задача 65:**Задайте значения M и N.
//  Напишите программу, которая выведет все
//  натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

using System;
using static System.Console;

Clear();
Write("Введите число 1 (M): ");
int st = int.Parse(ReadLine());
Write("Введите число 2 (N): ");
int en = int.Parse(ReadLine());


WriteLine(PrintNumbers(st , en));

string PrintNumbers(int start, int end)
{
    if (start == end)
    {
        //Console.WriteLine(end);
        return end.ToString();//"1";//start
    }
    
    string s = PrintNumbers(start,end-1) + ' ' + end.ToString();
    //Console.WriteLine(s);
    return (s);
}


// string PrintNumbers(int end)
// {
//     if (end == 1)
//     {
//         //Console.WriteLine(end);
//         return "1";
//     }
    
//     string s = PrintNumbers(end - 1) + ' ' + end.ToString();
//     //Console.WriteLine(s);
//     return (s);
// }