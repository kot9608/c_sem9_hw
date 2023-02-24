// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


using System;
using static System.Console;

Clear();
Write("Введите число 1 (N): ");
int n = int.Parse(ReadLine());
Write("Введите число 2 (M): ");
int m = int.Parse(ReadLine());

//int Akkerman (int N, int M);

int res=Akkerman(n,m);
Write(res);


int Akkerman(int NAkk, int MAkk)
{
    if (NAkk==0){return MAkk+1;}
    if (MAkk==0){return Akkerman(NAkk-1, 1);}
    else
    {
      return Akkerman((NAkk-1),Akkerman(NAkk,MAkk-1));
    } 
};



// int Akkerman(int NAkk, int MAkk)
// {
//     if (NAkk == 0)
//     {
//         //Console.WriteLine(end);
//         return MAkk+1;//"1";//start
//     }
//     if (MAkk==0)
//     {
//     MAkk=(Akkerman(NAkk-1, 1));
//     }
//     if (NAkk!=0 && MAkk!=0)
//     {
//     NAkk=(Akkerman(NAkk-1,(Akkerman(NAkk, MAkk-1))));
//     }
//     return MAkk+1;
// }
