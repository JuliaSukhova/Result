using System;
using static System.Console;

Clear();

static string[] ReadStringArrayFromConsole()
{
    Write("Введите массив строк через пробел: ");
    string[] arr = ReadLine().Split();
    return arr;
}

static string[] FilterShortStrings(string[] arr, int maxLength)
{
    // Создаем новый массив и заполняем его строками длиной не более maxLength символов
    string[] new_arr = new string[arr.Length];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= maxLength)
        {
            new_arr[count] = arr[i];
            count++;
        }
    }

    // Создаем новый массив с нужным размером и копируем в него элементы из нового массива
    string[] final_arr = new string[count];
    for (int i = 0; i < count; i++)
    {
        final_arr[i] = new_arr[i];
    }

    return final_arr;
}

static void PrintStringArray(string[] arr)
{
    WriteLine("Новый массив строк: " + string.Join(" ", arr));
}

string[] arr = ReadStringArrayFromConsole();
int maxLength = 3;
string[] filteredArr = FilterShortStrings(arr, maxLength);
PrintStringArray(filteredArr);