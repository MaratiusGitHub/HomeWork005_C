// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    Console.WriteLine($"[{String.Join(", ", array)}]");
    return array;
}

void result(int[] collection)
{
    int max = collection[0];
    int min = collection[0];
    for (int i = 0; i < collection.Length; i++)
    {
        if (max < collection[i])
        {
            max = collection[i];
        }
        else if (min > collection[i])
        {
            min = collection[i];
        }
    }
    Console.WriteLine("Максимальное число равно " + max);
    Console.WriteLine("Минимальное число равно " + min);
    Console.WriteLine($"Hазница между максимальным и минимальным элементов массива  равна {max - min}");
}

int[] array = CreateRandomArray(10, -50, 50);
result(array);
