// Вводим исходный массив строк с клавиатуры

Console.Write("Введите массив строк через пробел: ");
string[] arr = Console.ReadLine().Split();

// Создаем новый массив и заполняем его строками длиной не более 3 символов
string[] new_arr = new string[arr.Length];
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i].Length <= 3)
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

Console.WriteLine("Новый массив строк: " + string.Join(", ", final_arr)); 