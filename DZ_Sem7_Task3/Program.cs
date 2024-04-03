// Задайте произвольный массив.
// Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

// int[] array = { 5, 23, 7, 98, 2, 54 };
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.WriteLine("]");
}

void PrintElements(int[] arr, int i)
{
    if (i < 0) return;
    {
        Console.Write($"{arr[i]}  ");
        PrintElements(arr, i - 1);

    }
}

int[] arr = CreateArrayRndInt(10, 1, 100);
PrintArray(arr);

PrintElements(arr, arr.Length - 1);