// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Задаем массив строки.

string[] arr =  {"Good", "Never!!!","Ups","Left","I'm hungry","My food!", "bay"};

// Создаем метод вывода в консоль заданого массива
void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}
// Создаем метод вывода в консольнового массива
void PrintArraySorting(string[] sortingArray)
{
    for (int i = 0; i < sortingArray.Length; i++)
    {
        Console.Write(sortingArray[i] + " ");
    }
}
// Создаем метод отсеивания из массива элементов, которые больше 3-х знаков
string[] SortingArray(string[] array)
{
    string[] sortingArray = new string[array.Length];
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            sortingArray[temp] = array[i];
            temp++;
        }
    }
    return sortingArray;
}

Console.WriteLine("Выводим первоначальный рандомный массив: ");
PrintArray(arr);
Console.WriteLine("Выводим отсортированный массив с длинной не более 3 символов в элементе: ");
string[] sortingArray = SortingArray(arr);
PrintArraySorting(sortingArray);
