// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());
int[] array = GetArray(size);
PrintArray(array);
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
sum = sum + array[i];
    }
}

Console.WriteLine(" ");
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum}");


int[] GetArray(int lenght)
{
    int[] array = new int[lenght];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-5, 5);
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