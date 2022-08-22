// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123 ([5, 18, 123, 6, 2] -> 1; [1, 2, 3, 6, 2] -> 0)

Console.Clear();
int[] array = new int[10];
Random random = new Random();
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(1, 123);
    if (array[i] >=10 && array[i] <= 99)
    {
        count++;
    }
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
Console.WriteLine($"Количество элементов массива в диапазоне от 10 до 99 равно: {count}");