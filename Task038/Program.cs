// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива");
int X = int.Parse(Console.ReadLine()!);

int[] createArray()
{
    var random = new Random();

    var result = new int[X];

    for (long i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(0, 100);
    }

    return result;
}


int maxCalc(int[] array)
{
    int iMax = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > iMax)
        {
            iMax = array[i];
        }
    }

    return iMax;
}

int minCalc(int[] array)
{
    int iMin = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < iMin)
        {
            iMin = array[i];
        }
    }

    return iMin;
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
int iMin = minCalc(array);
Console.WriteLine("Минимальное число = " + iMin);
int iMax = maxCalc(array);
Console.WriteLine("Максимальное число = " + iMax);
int diff = iMax - iMin;
Console.WriteLine("Разница между числами = " + diff);