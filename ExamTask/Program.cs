// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] words = EnterWordsToArray();
Console.WriteLine();
PrintWordsFromArray(words);

string[] EnterWordsToArray()
{

    Console.WriteLine("Введите количество вводимых слов: ");
    int number = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[number];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} слово: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintWordsFromArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write(array[i]);
            Console.Write(" ");
        }
    }
    Console.WriteLine("]");
}