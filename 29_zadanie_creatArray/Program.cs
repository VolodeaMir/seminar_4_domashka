/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.Clear();
int[] arr = new int[8]; // Создаем цикл из 8 нулей

RandArray(arr);
PrintArray(arr);


// Генерируем маввив из 8 элементов от 0 и до 20 каждый.
void RandArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(0, 21);
}

// Печатаем массив
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
}

