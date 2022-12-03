// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


int[] NumbersArray(int m)
{
    int[] array = new int[m];
    for (int i = 0; i < m; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int CountNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

Console.Write("Введите количество чисел: ");
int countOfNumbers = Convert.ToInt32(Console.ReadLine());
if (countOfNumbers > 0)
{
    Console.WriteLine($"Введите по очереди числа: ");
    int[] arrayOfNumbers = NumbersArray(countOfNumbers);
    int countNumbers = CountNumbers(arrayOfNumbers);
    Console.WriteLine($"Среди введенных чисел положительных: {countNumbers}");
}
else Console.WriteLine("Введите положительное число");