// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

int size = 5;
double[] numbers = new double[size];

Random rnd = new Random();

for (int i = 0; i < size; i++)
{
    numbers[i] = rnd.Next(-100, 100) + rnd.NextDouble();
}
for (int i = 0; i < size; i++)
{
    Console.Write("Массив ");
    Console.Write($"{numbers[i]} ");
}
Console.WriteLine();

double max = numbers[0];
for ( int i = 0; i < size; i++)
{
   if (i < size && numbers[i] > max)
   {
      max = numbers[i];
   }
}

Console.WriteLine($"Максимальное число = {max}");

double min = numbers[0];
for ( int i = 0; i < size; i++)
{
   if (i < size && numbers[i] < min)
   {
      min = numbers[i];
   }
}

Console.WriteLine($"Минимальное число = {min}");
double diff = max - min;
Console.WriteLine($"Разница - {diff}");