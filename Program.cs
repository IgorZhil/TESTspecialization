//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых <=3 символам



using System;

string[] array = // Создаём массив;
{
    "1234",
    "1567",
    "-2",
    "computer science"

};

var result = new string[array.Length]; // вводим переменные 
var realSize = 0;  // массива;
foreach (var value in array)  // Вводим счетчики, которые считают длину массива из строки;
{
    if (value.Length <= 3)  // Проверяем длинну массива; Если длинна массива <=3;
    {
        result[realSize] = value; // Перезапускаем цикл заново;
        realSize++;
    }
}

Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));  // Выводим в консоль результаты;


