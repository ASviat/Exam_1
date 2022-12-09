// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.



string[] hell = new string[4] { "hello ", "2 ", "world ", ":-)" };
// for (int i = 0; i < 4; i++)
// {
//     Console.Write(hell[i]);
// }


HowMuchSimbols(hell);

void HowMuchSimbols(string[] array)
{
    for (int i=0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            Console.WriteLine(array[i]);
        } 
    }
}