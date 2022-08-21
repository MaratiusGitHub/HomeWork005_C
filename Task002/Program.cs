// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

void Result(int[] massive, int sum)
{
    for (int i = 1; i < massive.Length; i+=2)
    {
        sum += massive[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {sum}");
    ;
}

int[] array = CreateRandomArray(10, -10, 10);
Result(array, 0);