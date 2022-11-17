// Дан массив чисел. Напишите функцию, которая ищет заданное число в массиве и показывает нужный индекс в нем. При отсутствии числа возвращать -1.

Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());

int[] array = GetArray(size);
Console.WriteLine("Массив выглядит так: ");
PrintArray(array);
int findIndexNumber = 0;


Console.WriteLine("Введите любое число");
int number = int.Parse(Console.ReadLine());
FindIndexNumber(array);




int[] GetArray(int lenght)
{
    int[] array = new int[lenght];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 21);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(" ");
}

void FindIndexNumber(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (number == array[i])
        {
            Console.WriteLine($"{number} есть в массиве, его индекс равен {i}");
        }
        else
        {
            Console.WriteLine($"{number} нет в массиве, его индекс равен -1");
        }
        break;
    }
}