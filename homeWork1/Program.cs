﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = Convert.ToInt32(Console.ReadLine());

void findsnumber (int number2){

    int numberSekond = (number2 % 100) / 10; 
    Console.WriteLine(numberSekond);
}

findsnumber(number);