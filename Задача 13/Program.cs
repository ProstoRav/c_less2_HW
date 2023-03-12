/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

int number, loop, result;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out number);

if ((number >= 100) && (number < 1000))
    Console.Write($"Третья цифра числа {number} равна {number % 10}");
else if ((number <= -100) && (number > -1000))
    Console.Write($"Третья цифра числа {number} равна {(number % 10) * -1}");
else if (number > 999)
{
    loop = number;
    while (loop > 999)
        loop = loop / 10;
    result = loop % 10;
    Console.Write($"Третья цифра числа {number} равна {result}");
}
else if (number < -999)
{
    loop = number;
    while (loop < -999)
        loop = loop / 10;
    result = (loop % 10) * -1;
    Console.Write($"Третья цифра числа {number} равна {result}");
}
else
    Console.Write($"Третьей цифры у числа {number} нет");