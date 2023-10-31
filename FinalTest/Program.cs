// Задача:
// Написать программу,
// которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше,
// либо равна 3 символам. 

// Решение:

// Cоздаем метод для разделения строки из консоли в массив по знаку ","
string[] GetArrayStringConsole (string inConsolSymbol)
{
    string[] arraySymbol = new string[inConsolSymbol.Length];
    arraySymbol = inConsolSymbol.Split(",");
    return arraySymbol;
}
