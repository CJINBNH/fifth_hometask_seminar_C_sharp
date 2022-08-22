// Задайте с клавиатуры массив вещественных (double) чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
Console.WriteLine("Введине длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine('[' + string.Join(", ", array) + ']');

double diff = 0;
double max = array[0];
double min = array[0];
for (int j = 0; j < array.Length; j++)
{
    if (array[j] > max) max = array[j];
    if (array[j] < min) min = array[j];
}
diff = max - min;
Console.WriteLine($"Разность максимально и минимального чисел массива равна: {diff}");