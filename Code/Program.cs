﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void Main()
{
string[]? startStrigArray = ArrayOfString(GetStartString("Введите наборы символов разделенные пробелом: "));
PrintResult(startStrigArray, GetResultArray(startStrigArray));
}


string? GetStartString(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine();
}


string[] ArrayOfString (string? startString)
{
    return startString!.Split(" ");
}


string[] GetResultArray (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] resultArray = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[j] = array[i];
            j++;
        }
    }
    return resultArray;
}


void PrintResult(string[] startArray, string[] resultArray)
{
    System.Console.WriteLine();
    System.Console.WriteLine("[" + string.Join(", ",startArray) + "] → [" + string.Join(", ", resultArray) + "]");
    System.Console.WriteLine();
}


Main();