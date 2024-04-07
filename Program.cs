// // Задача: Написать программу, которая из имеющегося массива
//  строк формирует новый массив из строк, длина которых меньше, 
//  либо равна 3 символам. Первоначальный массив можно ввести с 
//  клавиатуры, либо задать на старте выполнения алгоритма. При 
//  решении не рекомендуется пользоваться коллекциями, лучше 
//  обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] items = { "Hello", "World", "125", "72", "yes" };

string[] new_items = new string[0];
int size = 0;

for (int i = 0; i < items.Length; i++)
{
    if (items[i].Length <= 3)
    {
        size += 1;
        Array.Resize(ref new_items, size);
        new_items[size - 1] = items[i];
    }
}
System.Console.Write("[");
for (int i = 0; i < new_items.Length; i++)
{
    System.Console.Write('"' + new_items[i] + '"');
    if (i != new_items.Length - 1)
    {
        System.Console.Write(", ");
    }
}
System.Console.WriteLine("]");




