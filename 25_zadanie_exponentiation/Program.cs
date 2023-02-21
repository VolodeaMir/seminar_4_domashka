/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

// Console.Clear();
// Console.Write("Введите число a: ");
// int num = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число b: ");
// int num2 = int.Parse(Console.ReadLine()!);
// int result = 1;

// for (int i = 0; i < num2; i++) result = result * num;

// Console.Write("Ваше число = " + result);

Console.Clear();
Console.Write("Введите число a: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b: ");
int num2 = int.Parse(Console.ReadLine()!);

Console.Write("Ваше число = " + GetStep(num, num2));

int GetStep(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++) result = result * a;
    return result;
}