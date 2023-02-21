/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

// Console.Clear();
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// int result = 0;

// while (num > 0)
// {
//     result += num % 10;
//     Console.WriteLine(result);
//     num = num / 10;
// }

// Console.WriteLine("Результат = " + result);

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine(GetSumDigits(num));

int GetSumDigits(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        // Console.WriteLine(result);
        number = number / 10;
    }
    return result;
}