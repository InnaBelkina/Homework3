// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000 || number > 99999)
{
    Console.WriteLine("Ошибка");
}
else
{
    int ost1 = number % 10000;
    int cifra2 = ost1 / 1000;

    int ost2 = number % 100;
    int cifra4 = ost2 / 10;

    if (number / 10000 == number % 10 && cifra2 == cifra4) 
    {
        Console.WriteLine("Число является палиндромом");
    }

    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}