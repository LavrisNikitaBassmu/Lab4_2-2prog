using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите предложение, завершающееся точкой:");
        string input = Console.ReadLine();

        // Убираем точку в конце для удобства обработки
        if (input.EndsWith("."))
        {
            input = input.TrimEnd('.');
        }

        // Разделяем строку на слова с помощью методов класса string
        string[] words = input.Split(new char[] { ' ', ',', '-' }, StringSplitOptions.RemoveEmptyEntries);
        string result = "";

        // Формируем новую строку с номерами слов
        for (int i = 0; i < words.Length; i++)
        {
            result += words[i] + "(" + (i + 1) + ")";
            if (i < words.Length - 1)
            {
                // Добавляем разделитель между словами
                result += " ";
            }
        }

        Console.WriteLine("Результат: " + result);
    }
}