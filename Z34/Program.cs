/*                          Домашнее задание к семинару 5 С#
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
Например:
[345, 897, 568, 234] -> 2           */

try
{
    Console.WriteLine("Введите размерность массива:");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = CreateArray(size);
    PrintArray(array);
    CountEvenNum(array);
}
catch
{
    Console.WriteLine("Ошибка: некорректный ввод!");
}

int[] CreateArray(int size)  // принимает размер массива и возвращает сгенерированный массив
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}

void PrintArray(int[] array)
{
    foreach (int el in array)   //этот цикл только для просмотра и тут нет индексов
        Console.Write($"{el}, ");
    Console.WriteLine();
}

int CountEvenNum(int[] array) // подсчёт кол-ва четных чисел 
{
    int count = 0;
    int size = array.Length - 1;
    for (int i = 0; i < size; i++)
        if (array[i] % 2 == 0 && i < size) // проверка на чет 
            count = count + 1;
    Console.WriteLine($"Кол-во чётных чисел в массиве: {count}");
    return count;
}