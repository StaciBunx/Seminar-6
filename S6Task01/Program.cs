//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4

using System;
using static System.Console;
Clear();

WriteLine("Введите числа через запятую: ");
int[] array = GetArrayFromString(ReadLine());
WriteLine($"[{String.Join(",", array)}]");
WriteLine(CountPositivDigits(array));

int[] GetArrayFromString(string arrStr)
{
    string[] arS = arrStr.Split(',', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[arS.Length];
    for (int i = 0; i < arS.Length; i++)
    {
        result[i] = int.Parse(arS[i]);
    }
    return result;

}

int CountPositivDigits(int[] newArray)
{
    int count = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i] > 0) count++;
    }
    return count;
}

