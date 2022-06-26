//Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5) // ответ в примере неверный

using System;
using static System.Console;
Clear();

WriteLine("Введите параметр b1: ");
int b1 = int.Parse(ReadLine());
WriteLine("Введите параметр k1: ");
int k1 = int.Parse(ReadLine());
WriteLine("Введите параметр b2: ");
int b2 = int.Parse(ReadLine());
WriteLine("Введите параметр k2: ");
int k2 = int.Parse(ReadLine());
FindIntersection(b1, k1, b2, k2);

void FindIntersection(int n1, int n2, int n3, int n4)
{
    string point = string.Empty;
    double X = (n3 - n1) / (n2 - n4);
    double Y = n2 * X + n1;
    WriteLine(point = $"({X};{Y})");
}


