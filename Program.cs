// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hе11о", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"] 
// ["Russia", "Denmark", "Kazan"] -> []

Console.Clear();
int count = 0;
int j = 0;
string[] array1 = {"hе11о", "2", "world", ":-)"};
string[] array2 = new string[count];
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3)
    {
        count++;
        Array.Resize(ref array2, count);
        array2[j] = array1[i];
        j++;
    }
}
Console.WriteLine($"[{string.Join(", ", array1)}] -> [{string.Join(", ", array2)}]");