// Задача 3: Напишите программу, которая принимает на вход целое число
// из отрезка [10, 99] и показывает наибольшую цифру числа.

int num = 72;
if (num > 10 && num < 99) {
    int first_digit = num % 10;
    int second_digit = num / 10;
    if (first_digit >  second_digit) {
        Console.Write(first_digit);
    }
    else {
        Console.Write(second_digit);
    }
}