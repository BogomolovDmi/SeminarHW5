// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива");
int X = int.Parse(Console.ReadLine()!);

int[] createArray()
{
    var random = new Random();

    var result = new int[X];

    for (long i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(-100, 100);
    }

    return result;
}

int sumOdd(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            summ = summ + array[i];
        }
    }
    return summ;
}

void printArray1(int[] array)
{
    Console.Write("[");

    for (var i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);

        if (i != array.Length - 1)
            Console.Write(", ");
    }

    Console.Write("]");
    Console.WriteLine();
}

var array = createArray();
printArray1(array);
int summ = sumOdd(array);
Console.WriteLine(summ);