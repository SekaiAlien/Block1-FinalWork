// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] > [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] > [“-2”]
// [“Russia”, “Denmark”, “Kazan”] > []


using static System.Console;
Clear();

int limit = 3;
string[] userArray = AskArray();
string[] result = LessThanCopy(userArray, limit);

WriteLine($"Введенный массив: [{String.Join(", ", userArray)}]");
WriteLine($"-> Элементы массива, длина которых меньше {limit} символов: [{String.Join(", ", result)}]");


string[] LessThanCopy(string[] input, int lim)
{
    string[] output = new string[GetArrayLength(input, lim)];
    int idx = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= lim)
        {
            output[idx] = input[i];
            idx++;
        }
    }
    return output;
}

int GetArrayLength(string[] checkArray, int lmt)
{
    int len = 0;
    for (int i = 0; i < checkArray.Length; i++)
    {
        if (checkArray[i].Length <= lmt) len++;
    }
    return len;
}

string[] AskArray()
{
    WriteLine("Введите массив, разделяя элементы пробелом");
    return ReadLine().Split(" ");
}