// Задача 4: Напишите программу, которая на вход принимает натуральное число N,
// а на выходе показывает его цифры через запятую.

int n = 568;
int num = n;
int pow = 1;

while (n > 9) {
    while (num > 9) {
    num /= 10;
    pow = pow * 10;
    }   
    Console.Write (num + ",");
    n = n % (pow);
    num = n;
    pow = 1;
    }
Console.Write (n);





