// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами 
// (длина массива 5 элементов). Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] array = new int[5];
// void FillArray(int[] array)
// {
//     int index = 0;
//     while (index < array.Length)
//     {
//         array[index] = new Random().Next(100, 1000); // 0 и 1
//         index++;
//     }
// }
// void PrintArray(int[] array)
// {
//     int index = 0;
//     while (index < array.Length)
//     {
//         Console.Write(array[index] + " ");
//         index++;
//     }
// }
// int[] array_1 = new int[5];
// FillArray(array_1);
// PrintArray(array_1);
// int count = 0; // счётчик количества чётных элементов массива
// for (int i = 0; i < array_1.Length; i++)
// {
//     if (array_1[i] % 2 == 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Количество чётных элементов в данном массиве = {count} ");


// Задача 36: Задайте одномерный массив, заполненный случайными числами (длина массива 5 элементов).
//  Найдите сумму элементов, стоящих на нечётных индексах (индексы с нуля).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// void FillArray(int[] array)
// {
//     int index = 0;
//     while (index < array.Length)
//     {
//         array[index] = new Random().Next(-100, 100); // 0 и 1
//         index++;
//     }
// }

// void PrintArray(int[] array)
// {
//     int index = 0;
//     while (index < array.Length)
//     {
//         Console.Write(array[index] + " ");
//         index++;
//     }
// }

// int[] array_1 = new int[5];

// FillArray(array_1);
// PrintArray(array_1);
// int summ = 0; // счётчик суммы элементов массива стоящих на нечётных индексах

// for (int i = 0; i < array_1.Length; i++)
// {
//     if (i % 2 == 1)
//     {
//         summ += array_1[i];
//     }
// }
// Console.WriteLine($"Сумма элементов массива с нечётными индксами = {summ}");


// Задача 38: Задайте массив вещественных чисел от -100 до 100 (длина массива 5 элементов).
//  Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// void FillArray(int[] array)
// {
//     int index = 0;
//     while (index < array.Length)
//     {
//         array[index] = new Random().Next(-100, 101);
//         index++;
//     }
// }

// void PrintArray(int[] array)
// {
//     int index = 0;
//     while (index < array.Length)
//     {
//         Console.Write(array[index] + " ");
//         index++;
//     }
// }

// int[] array_1 = new int[5];

// FillArray(array_1);
// PrintArray(array_1);
// int summ = 0; // Разница между максимальным значением и минимальным значением массива
// int maxi = array_1[0];
// int min = array_1[0];
// for (int i = 0; i < array_1.Length; i++)
// {
//     if (array_1[i] > maxi)
//     {
//         maxi = array_1[i];
//    }
//     if (array_1[i] < min)
//     {
//         min = array_1[i];
//     }
// }
// Console.WriteLine();
// summ = maxi - min;
// Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {summ}");


// Доп. задачи
// Задача 3: Задайте массив из 8 случайных чисел из промежутка [-9, 9]. 
// Напишите программу получает на вход число и определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// void FillArray(int[] array)
// {
//     int index = 0;
//     while (index < array.Length)
//     {
//         array[index] = new Random().Next(-9, 10);
//         index++;
//     }
// }
// void PrintArray(int[] array)
// {
//     int index = 0;
//     while (index < array.Length)
//     {
//         Console.Write(array[index] + " ");
//         index++;
//     }
// }

// Console.WriteLine("Введите число для проверки: ");
// int x = Convert.ToInt32(Console.ReadLine()); // Х - проверяемое число 
// int[] array_1 = new int[8];
// FillArray(array_1);
// PrintArray(array_1);
// int count = 0; // переменная показывает встречается число или нет 
// Console.WriteLine();
// for (int i = 0; i < array_1.Length; i++)
// {
//     if (array_1[i] == x)
//     {
//         count++;
//     }
// }
// if (count > 0)
// {
//     Console.WriteLine("Введённое число присутсвует в массиве");
// }
// else
// {
//     Console.WriteLine("Введённое число не присутсвует в массиве");
// }


// Задача 4: Задайте массив из 10 случайных чисел из промежутка [-100, 100]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 10 элементов. В своём решении сделайте для 10
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

 void FillArray(int[] array)
 {
     int index = 0;
     while (index < array.Length)
     {
         array[index] = new Random().Next(-100, 101);
         index++;
     }
 }

 void PrintArray(int[] array)
 {
     int index = 0;
     while (index < array.Length)
     {
         Console.Write(array[index] + " ");
         index++;
     }
 }

 int[] array_1 = new int[8];
 FillArray(array_1);
 PrintArray(array_1);
 int count = 0; // переменная показывает количество чисел в отрезке от 10 до 99
 Console.WriteLine();
 for (int i = 0; i < array_1.Length; i++)
 {
     if (array_1[i] >= 10 && array_1[i] <= 99)
     {
         count++;
     }
 }
 Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] = {count}");
