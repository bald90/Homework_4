// Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int DataEntry(string str)                   // 1.1. Метод ввода данных
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int FindSum(int number)                     // 2.1 Метод поиска суммы
{
    int sum = 0;
    for (int i = number; i > 0; i = i / 10)
        sum = sum + i % 10;
    return sum;
}

int number = DataEntry("Введите число");    // 1.0 Запросить число
int sumDigit = FindSum(number);             // 2.0 Обратиться к методу поиска суммы
Console.WriteLine("-> " + sumDigit);        // 3.0 Вывести сумму