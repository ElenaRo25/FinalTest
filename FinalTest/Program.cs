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

// Cоздаем метод, сортирующий символы из массива:
// Отсчитываем количество удовлетворяющих требований для определения длинны нового массива.
// Создаем массив по выясненому количеству и заносим туда символы, удовлетворяющие требованиям.
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
            arrayThreeSymbol[j] = symbol;
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

// Создаем "клиентский код" для вызова методов и обработки информации через консоль:
// выводим поясняющую информационную строку для пользователя в консоле: "Введите набор символов через запятую : "
// присваиваем введенное в консоле от пользователя символы "string inStringSymbol = console.ReadLine()!"
// присваиваем массиву преобразованную строку через метод `string[] arraySymbol = GetArrayStringConsole(inStringSymbol)`
Console.Write("Введите набор символов через запятую : ");
string inStringSymbol = Console.ReadLine()!;
string[] arraySymbol = GetArrayStringConsole(inStringSymbol)!;
Console.WriteLine();
Console.Write("Ваши введенные символы : ");
Print(arraySymbol);
Console.WriteLine();
Console.Write("Ваши введенные символы длинной меньше либо равны 3 : ");
Print(GetArrayThreeSymbol(arraySymbol));
Console.WriteLine();