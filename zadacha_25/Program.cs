// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

int DataEntry(string str)                               // 1.1. Метод ввода данных
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int FindExp(int numberA, int numberB)                   // 2.1 Метод возведения в степень
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
        result *= numberA;
    return result;
}

int numberA = DataEntry("введите первое число = ");    //1.0 обратиться к методу ввода данных
int numberB = DataEntry("введите второе число = ");    //1.0 обратиться к методу ввода данных

int result = FindExp(numberA, numberB);                // 2.0 обратиться к методу возведения в степень
Console.WriteLine("-> " + result);                     // 3.0 вывести введенные числа




