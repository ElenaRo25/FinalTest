// Задача:
// Написать программу,
// которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше,
// либо равна 3 символам. 

// Решение:

// Cоздаем метод для разделения строки из консоли в массив по знаку ",":
string[] GetArrayStringConsole (string inConsolSymbol)
{
    string[] arraySymbol = new string[inConsolSymbol.Length];
    arraySymbol = inConsolSymbol.Split(",");
    return arraySymbol;
}

// Cоздаем метод, сортирующий символы из массива.
// Отсчитываем количество удовлетворяющих требований для определения длинны нового массива.
// Создаем массив по выясненому количеству и заносим туда символы, удовлетворяющие требованиям:
string[] GetArrayThreeSymbol (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string symbol = array[i];
        if (symbol.Length <= 3)
        {
            count++;
        }
    }
    string[] arrayThreeSymbol = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        string symbol = array[i];
        if (symbol.Length <= 3)
        {
            arrayThreeSymbol[j] = simvol;
            j++;
        }
    }
    return arrayThreeSymbol;
}

// Создаем метод для вывода информации из массивов с использованием циклического вывода каждого элемента массива:
void Print (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
Console.WriteLine();
}
