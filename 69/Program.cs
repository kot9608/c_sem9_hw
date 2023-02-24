// **Задача 69:**Напишите программу,
//  которая на вход принимает два числа A и B,
//   и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5-> 243(3⁵)

// A = 2; B = 3-> 8



using System;
using static System.Console;

Clear();
Write("Введите число: ");
int st = int.Parse(ReadLine());
Write("Введите степень: ");
int stepen = int.Parse(ReadLine());
//int res =0;

WriteLine(PrintNumbers(st, stepen));

int PrintNumbers(int start, int step)
{
    if (step==0)
    {
        //Console.WriteLine(start);
        return 1;//"1";//start
    }

    int res = PrintNumbers(start, step-1) * start ;

    //Console.WriteLine(res);
    return res;
}


// using System;
// using static System.Console;


// // Ввод числа с консоли
// int Prompt(string message)
// {
//     Write(message);
//     return Convert.ToInt32(ReadLine()!);
// }

// int a = Prompt("A = ");
// int b = Prompt("B = ");

// Write(Power(a, b));

// int Power(int num, int pow)
// {
//     if (pow == 0)
//     {
//         return 1;
//     }
    
//     int result = num * Power(num, pow - 1);
//     return result;
// }