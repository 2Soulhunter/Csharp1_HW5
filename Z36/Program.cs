/*                          Домашнее задание к семинару 5 С#
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
Например:
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0            */

try
{
    Console.WriteLine("Введите размерность массива:");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = CreateArray(size);
    PrintArray(array);
    SumOddNum(array);
}
catch
{
    Console.WriteLine("Ошибка: некорректный ввод!");
}

int[] CreateArray(int size)  // принимает размер массива и возвращает сгенерированный массив
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-100, 100);
    return array;
}

void PrintArray(int[] array)
{
    foreach (int el in array)   //этот цикл только для просмотра и тут нет индексов
        Console.Write($"{el}, ");
    Console.WriteLine();
}

int SumOddNum(int[] array) // подсчёт суммы чисел элементов массива, стоящих на нечётных позициях 
{
    int sum = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
        if (i % 2 != 0 && i <= size) // проверка на нечётность 
            sum += array[i];
    Console.WriteLine($"Сумма чисел нечётных элементов массива: {sum}");
    return sum;
}