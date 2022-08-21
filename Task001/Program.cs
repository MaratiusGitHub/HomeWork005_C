//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел 
//в массиве.
//[345, 897, 568, 234] -> 2

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

void Result(int[] massive, int count1, int count2)
{
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] % 2 == 0)
        {
            count2 += 1;
        }

        else
        {
            count1 += 1;
        }
    }
    Console.WriteLine($"Количество нечетных чисел в массиве равно {count1}");
    Console.WriteLine($"Количество четных чисел в массиве равно {count2}");
}

int[] myArray = CreateRandomArray(10, 100, 999);
Result(myArray, 0, 0);