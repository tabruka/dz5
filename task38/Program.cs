// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());
double[] array = new double[size];
FillArrayRandomarray(array);
PrintArray(array);
double min = 0;
double max = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}

Console.WriteLine($"Массив состоит из {array.Length} чисел . Максимальное значение = {max}, минимальное значение = {min}");

if (max > 0 && min < 0)
{
    Console.WriteLine($"Разница между максимальным и минимальным значением = {min - max}");
}
else
{
    Console.WriteLine($"Разница между максимальным и минимальным значением = {max + min}");
}


void FillArrayRandomarray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(-100,100)) / 100;
        }
}
void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    Console.WriteLine();
}