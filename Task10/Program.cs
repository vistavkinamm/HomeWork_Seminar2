﻿int num = new Random().Next(100, 1000);
int num1 = num % 100;
int num2 = num1 / 10;

Console.WriteLine(num);
Console.WriteLine($"Вторая цифра числа:{num2}");

