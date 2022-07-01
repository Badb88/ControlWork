/*
**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.

**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []
*/

void FillArray(string[] collection)
{
    Console.WriteLine("Введите элементы массива: ");
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write($"[{i}] ");
        collection[i] = Console.ReadLine()!;
    }
}

Console.Write("Задайте размер массива: ");

int sizeArray = Convert.ToInt32(Console.ReadLine());
string[] array = new string[sizeArray];