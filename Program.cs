//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива:  ");
int size = int.Parse(Console.ReadLine()!);
int[] numbers = new int[size];
RandonNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);

void RandonNumbers(int[] numbers)
{
    for(int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100,900);
    }
}


int count = 0;

for (int i = 0; i < size; i++)
{
if (numbers[i] % 2 == 0)
count++;
}
Console.WriteLine($"из {size} чисел, {count} четных");


void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < size; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}