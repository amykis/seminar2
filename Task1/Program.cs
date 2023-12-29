// Задача 1: Напишите программу, которая принимает на вход трехзначное число
// и удаляет вторую цифру этого числа

int num = 345;
int first_dig = num / 100;
int second_digit = num % 10;
Console.Write($"{first_dig}{second_digit}");

// Задача 2: Напишите программу, которая принимает на вход
// трехзначное число и возводит вторую цифру этого числа в степень,
// равную третьей цифре.

int num = 123;
int first_dig = (num % 100) /10;
int second_digit = num % 10;
int pow = 1;
for (int i=0; i < second_digit; i++) 
{
    pow = pow * first_dig;
}
Console.Write($"Степень = {second_digit}, возводимое число = {first_dig}, результат = {pow}");

// Задача 3: Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если второе число некратно первому,
// то программа выводит остаток от деления.

int first_num = 16;
int second_num = 8;

if (first_num % second_num == 0) {
    Console.Write("Да");
}
else {
    Console.Write($"Нет, {first_num % second_num}");
}

// Задача 4: Напишите программу, которая выводит третью с начала цифру заданного
// числа или сообщает, что третьей цифры нет.

int num = 25;
if (num > 99) {

    while (num > 999 ) {
        num /= 10;
    }
    Console.Write ($"Third digit is {num % 10}");
}
else {
    Console.Write("Нет 3 цифры");
}