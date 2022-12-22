// /*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// */

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

Console.Write("Введите элементы через пробел: ");
int[] array = Array.ConvertAll((Console.ReadLine() ?? "").Split(), int.Parse);
PrintArray(array);
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"Кол-во элементов > 0: {count}");