// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int size = 5;
int[] numbers = new int[size];

Random rnd = new Random();

for (int i = 0; i < size; i++)
{
    numbers[i] = rnd.Next(100, 1000);
}
for (int i = 0; i < size; i++)
{
    Console.Write($"{numbers[i]} ");
}
Console.WriteLine();

int counter = 0;
for ( int i = 0; i < size; i++)
{
   if (i < size && numbers[i] % 2 == 0)
   {
      counter++;
   }
}
Console.WriteLine($"Количество четных чисел в массиве - {counter}.");