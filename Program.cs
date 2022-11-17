//В десятичой системе нахождения цифр
// 456 / 100 => 4
// 456 % 100 => 56 + _______
// 456 / 10 => 45 + __ !
// 456 % 10 => 6     ! !
// 56 / 10 => 5 <----! !  
// 45 % 10 => 5 <----- !    

//Нахождение четности (%2)
// 4 % 2 => 0 - четное
// 5 % 2 => 1 - нечетное
// 7 % 2 => 1 (7 / 2 = 3 1/2) - нечетное

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

/*
int SecondNum2Digits (int number)
{
    int current = (number % 100) / 10;
    return current;
}

Console.WriteLine ($"Enter a three-digit number: ");
int userNum = Convert.ToInt32(Console.ReadLine());

if ( userNum > 99 && userNum < 1000)
{
    int result = SecondNum2Digits (userNum);
    Console.WriteLine ($"Second digit of the number {userNum} is {result} ");
}
else Console.WriteLine ($"Number {userNum} is not three digits! Enter a THREE-DIGIT number!");
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

/*
int ThreeNumDigits (int number)
{
    while ( number > 1000)
    {
        number = number / 10;
    }
    int result = number % 10;
    return result;
}

Console.WriteLine($"enter any number: ");
int userNum = Convert.ToInt32(Console.ReadLine());

if ( userNum > 99)
{
    int ThreeNum = ThreeNumDigits (userNum);
    Console.WriteLine($"The third digit of your number {userNum} is {ThreeNum} ");
}
else Console.WriteLine($"The entered number {userNum} does not contain the third digit");
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет


