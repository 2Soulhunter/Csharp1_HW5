/*                          Домашнее задание к семинару 5 С#
Задача 38: Задайте массив случайных вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
*/

try
{
    Console.WriteLine("Введите размерность массива:");
    int size = Convert.ToInt32(Console.ReadLine());
    double[] array = CreateArray(size);
    PrintArray(array);
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {DiffMinMaxEl(array)}");
}
catch
{
    Console.WriteLine("Ошибка: некорректный ввод!");
}

double[] CreateArray(int size)  // принимает размер массива и возвращает сгенерированный массив
{
    Random Rand = new Random();
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++) array[i] = Rand.NextDouble();
    return array;
}

void PrintArray(double[] array)
{
    foreach (double el in array)   //этот цикл только для просмотра и тут нет индексов
        Console.Write($"{el}, ");
    Console.WriteLine();
}

double DiffMinMaxEl(double[] array) // Вычисление разницы между макс и мин элементами массива 
{
    double diff = 0;
    int iMin = 0;
    int iMax = 0;
    //int temp = 0;
    int size = array.Length;
    //int ix = 0;
    for (int i = 0; i < size; i++)              // Поиск минимального и максимального элементов
    {
        if (array[i] < array[iMin]) iMin = i;
        if (array[i] > array[iMax]) iMax = i;
    }
    diff = array[iMax] - array[iMin];           // Вычисление разницы между макс и мин элементами
    return diff;
}