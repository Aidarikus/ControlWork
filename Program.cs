﻿using static Methods;

string task1 = "Задача: Написать программу, которая из имеющегося массива строк формирует ";
string task2 = "новый массив из строк, длина которых меньше, либо равна 3 символам.";
Console.WriteLine(task1 + "\n" + task2);
Console.WriteLine();

string[] array = CreateStringArray();
PrintArray(array, "Исходный массив: ");

string[] arrayShort = GenerateNewArray(array);
PrintArray(arrayShort, "Результат: ");