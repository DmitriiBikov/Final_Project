// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символов.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения агоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами


string[] GetString()
{
    Console.WriteLine("Введите значения через запятую: ");
    return Console.ReadLine().Split(",");

}

int GetLength(string[] array, int n)
{
    int len = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
            len++;
    }
    return len;
}

string[] FindLess(string[] inputArr, int n)
{
    string[] result = new string[GetLength(inputArr, n)];
    for (int i = 0, j = 0; i < inputArr.Length; i++)
    {
        if (inputArr[i].Length <= n)
        {
            result[j] = inputArr[i];
            j++;
        }
    }
    return result;
}

string[] input = GetString();
string[] output = FindLess(input, 3);

Console.WriteLine($"Введено раннее: {string.Join(", ", input)}");
Console.WriteLine($"Результат из строк, длина которых меньше либо равна 3 символов : {string.Join(", ", output)}");