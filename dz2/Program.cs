﻿// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X != 0 и Y != 0 и выдает номер координатной четверти плоскости, в которой 
// находится эта точка.

int x = 4;
int y = -2;

if (x > 0 && y > 0) {
    Console.Write("1");
}
if (x < 0 && y > 0) {
    Console.Write("2");
}
if (x < 0 && y < 0) {
    Console.Write("3");
}
if (x > 0 && y < 0) {
    Console.Write("4");
}