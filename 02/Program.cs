// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.

int size = 5;
int[] numbers = new int[size];

Random rnd = new Random();

for (int i = 0; i < size; i++)
{
    numbers[i] = rnd.Next(0, 100);
}
for (int i = 0; i < size; i++)
{
    Console.Write($"{numbers[i]} ");
}
Console.WriteLine();

int sum = 0;
for ( int i = 1; i < size; i=i+2)
{
   if (i % 2 == 1)sum += numbers[i];
}
Console.WriteLine($"Сумма чисел с нечетными индексами - {sum}.");
