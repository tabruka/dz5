// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());
int[] array = GetArray(size);
PrintArray(array);
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
count = count + 1;
    }
}
Console.WriteLine(" ");
Console.WriteLine($"четных чисел в массиве: {count}");

int[] GetArray(int lenght)
{
    int[] array = new int[lenght];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}