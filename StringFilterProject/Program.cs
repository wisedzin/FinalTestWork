using System;

class Program
{
    static void Main()
    {
        // Задаем исходный массив строк
        string[] inputArray = { "hello", "2", "world", ":-)", "yes", "no", "123", "abc" };

        // Можно раскомментировать следующую строку, чтобы вводить массив с клавиатуры
        // string[] inputArray = GetArrayFromUser();

        // Вызываем метод для формирования нового массива
        string[] resultArray = FilterArray(inputArray);

        // Выводим результат
        Console.WriteLine("Исходный массив: " + string.Join(", ", inputArray));
        Console.WriteLine("Новый массив: " + string.Join(", ", resultArray));
    }

    static string[] FilterArray(string[] array)
    {
        // Считаем количество строк, длина которых <= 3
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив нужного размера
        string[] result = new string[count];
        int index = 0;

        // Заполняем новый массив подходящими строками
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                result[index] = array[i];
                index++;
            }
        }

        return result;
    }

    static string[] GetArrayFromUser()
    {
        Console.WriteLine("Введите количество строк в массиве:");
        int size = int.Parse(Console.ReadLine());
        string[] array = new string[size];

        Console.WriteLine("Введите строки:");
        for (int i = 0; i < size; i++)
        {
            array[i] = Console.ReadLine();
        }

        return array;
    }
}
