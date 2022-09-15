// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hе11о", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"] 
// ["Russia", "Denmark", "Kazan"] -> []

Console.Clear();
int size = 0;
int index = 0;
string[] array1 = {"hе11о", "2", "world", ":-)"};
string[] array2 = new string[size];
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3)
    {
        size++;
        Array.Resize(ref array2, size);
        array2[index] = array1[i];
        index++;
    }
}
Console.WriteLine($"[{string.Join(", ", array1)}] -> [{string.Join(", ", array2)}]");