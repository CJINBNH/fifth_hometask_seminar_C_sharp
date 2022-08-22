// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();
int[] array = new int[10];
Random random = new Random();
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(1, 10);
}
Console.WriteLine('[' + string.Join(", ", array) + ']');

for (int j = 1; j < array.Length; j = j + 2)
    {
        sum = sum + array[j];
    }
Console.WriteLine($"Сумма элементов массива с нечеными индексами равна: {sum}");