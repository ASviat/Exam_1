// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.





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

string[] words = EnterWordsToArray();




PrintWordsFromArray(words);

void PrintWordsFromArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.WriteLine(array[i]);
        }
    }
}