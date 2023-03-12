/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

int number;
Console.Write($"Введите трёхзначное число: ");
int.TryParse(Console.ReadLine()!, out number);

if ((number >= 100) && (number < 1000))
    Console.Write($"Вторая цифра числа {number} равна {(number % 100 - number % 10) / 10}");
else if ((number <= -100) && (number > -1000))
    Console.Write($"Вторая цифра числа {number} равна {(number % 100 - number % 10) / -10}");
else
    Console.Write($"Число не трёхзначное");