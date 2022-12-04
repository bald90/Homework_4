// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] ---------ошибка? тут не 8 элементов
// 6, 1, 33 -> [6, 1, 33]----------------------ошибка? тут не 8 элементов

Console.Clear();

int[] FillArray(int[] array)                      // Метод создания рандомного массива
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 10);     // Рандомайзер чисел от 0 до 10
        array[1] = 52;                           // Поставил искусственно, чтобы как в примере преобладали однозначные числа
        array[6] = 21;
    }
    return array;
}

void PrintArray(int[] col)                       // Метод вывода массива в терминал
{
    int count = col.Length;
    int i;
    for (i = 0; i < count; i++)
    {
        Console.Write(col[i] + " ");
    }
}

int[] array = new int[8];

array = FillArray(array);
PrintArray(array);