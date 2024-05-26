Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
 
 # String Filter Project

## Описание

Этот проект представляет собой консольное приложение на C#, которое фильтрует строки из массива, длина которых меньше или равна 3 символам. 

## Установка

Для работы с проектом вам потребуется .NET SDK. Вы можете скачать и установить его с [официального сайта .NET](https://dotnet.microsoft.com/download).

## Запуск проекта

1. Склонируйте или загрузите проект в вашу локальную систему.
2. Откройте терминал и перейдите в папку проекта.
3. Выполните следующие команды для сборки и запуска проекта:

   ```sh
   dotnet build
   dotnet run

## Пример использования

Программа запускается и выводит исходный массив строк, а затем новый массив, содержащий только те строки, длина которых меньше или равна 3 символам.

# Блок-схема

![Блок-схема](<Снимок экрана (28)-1.png>)

```C#
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
```
## Результат запуска:
![Скриншот терминала](<Снимок экрана 2024-05-27 005950.png>)

## Коммиты:
![Скриншот Коммитов с ГитХаба](<Снимок экрана 2024-05-27 010314.png>)