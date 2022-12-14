//В десятичой системе нахождения цифр
// 456 / 100 => 4
// 456 % 100 => 56 + __
// 456 / 10 => 45 + _  |
// 456 % 10 => 6     | |
// 56 / 10 => 5 <----- |  
// 45 % 10 => 5 <-------     

//Нахождение четности (%2)
// 4 % 2 => 0 - четное
// 5 % 2 => 1 - нечетное
// 7 % 2 => 1 (7 / 2 = 3 1/2) - нечетное

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

//Вариант 1 (не работает с отрицательными числами)

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

//Вариант 2 (не работает с отрицательными числами)

/*
void SecondNum2Digits (int number)
{
    if (number > 99 && number < 1000)
    {
        int current = (number % 100) / 10;
        Console.WriteLine ($"Second digit of the number {number} is {current} ");
    }
    else Console.WriteLine ($"Number {number} is not three digits! Enter a THREE-DIGIT number!");
}

Console.WriteLine ($"Enter a three-digit number: ");
int userNum = Convert.ToInt32(Console.ReadLine());
SecondNum2Digits (userNum);
*/

//Вариант 3 (работает с отрицательными числами)

/*
void SecondNum2Digits (int number)
{
    if (number > 99 && number < 1000)
    {
        int current = (number % 100) / 10;
        Console.WriteLine ($"Second digit of the number {number} is {current} ");
    }
    else 
    {
        if (number < -99 && number > -1000 )
        {
        int current = (number % 100) / 10;
        Console.WriteLine ($"Second digit of the number {number} is {current} ");
        }
        else
        {
            Console.WriteLine ($"Number {number} is not three digits! Enter a THREE-DIGIT number!");
        }
    }
}

Console.WriteLine ($"Enter a three-digit number: ");
int userNum = Convert.ToInt32(Console.ReadLine());
SecondNum2Digits (userNum);
*/

//Вариант 4 (работает с отрицательными числами, версия с выводом положительной цифры при вводе отрицательного числа )

/*
void SecondNum2Digits (int number)
{
    if (number > 99 && number < 1000)
    {
        int current = (number % 100) / 10;
        Console.WriteLine ($"Second digit of the number {number} is {current} ");
    }
    else 
    {
        if (number < -99 && number > -1000 )
        {
        int current = (number % 100) / -10;
        Console.WriteLine ($"Second digit of the number {number} is {current} ");
        }
        else
        {
            Console.WriteLine ($"Number {number} is not three digits! Enter a THREE-DIGIT number!");
        }
    }
}

Console.WriteLine ($"Enter a three-digit number: ");
int userNum = Convert.ToInt32(Console.ReadLine());
SecondNum2Digits (userNum);
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

//Вариант 1 (не работает с отрицательными числами)

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

//Вариант 2 (не работает с отрицательными числами)

/*
void ThreeNumDigits (int number)
{
    if (number > 99)
    {
        while ( number > 1000)
        {
            number = number / 10;
        }
        int result = number % 10;
        Console.WriteLine($"The third digit of your number {number} is {result} ");
    }
    else
    {
        Console.WriteLine($"The entered number {number} does not contain the third digit");
    }     
}

Console.WriteLine($"enter any number: ");
int userNum = Convert.ToInt32(Console.ReadLine());

ThreeNumDigits (userNum);
*/

//Вариант 3 (работает с положительными и отрицательными числами)

/*
void ThreeNumDigits (int number)
{
    int realNum = number;
    int count = number / 100;

    if (count > 0)
    {
        while ( number > 1000)
        {
            number = number / 10;
        }
        int result = number % 10;
        Console.WriteLine($"The third digit of your number {realNum} is {result} ");
        
    }
    else 
    {
        if (count < 0)
        {
            while ( number < -1000)
            {
                number = number / 10;
            }
            int result = number % 10;
            Console.WriteLine($"The third digit of your number {realNum} is {result} ");
        }
        else 
        {
            Console.WriteLine($"The entered number {realNum} does not contain the third digit");
        }
    }
}

Console.WriteLine($"enter any number: ");
int userNum = Convert.ToInt32(Console.ReadLine());
ThreeNumDigits (userNum);
*/

//Вариант 4 (работает с положительными и отрицательными числами, версия с выводом положительной цифры при вводе отрицательного числа)

/*
void ThreeNumDigits (int number)
{
    int realNum = number;
    int count = number / 100;

    if (count > 0)
    {
        while ( number > 1000)
        {
            number = number / 10;
        }
        int result = number % 10;
        Console.WriteLine($"The third digit of your number {realNum} is {result} ");
        
    }
    else 
    {
        if (count < 0)
        {
            while ( number < -1000)
            {
                number = number / 10;
            }
            int result = number % 10;
            Console.WriteLine($"The third digit of your number {realNum} is {result * -1} ");
        }
        else 
        {
            Console.WriteLine($"The entered number {realNum} does not contain the third digit");
        }
    }
}

Console.WriteLine($"enter any number: ");
int userNum = Convert.ToInt32(Console.ReadLine());
ThreeNumDigits (userNum);
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

//Вариант 1

/*
void Weekend (int number)
{
    if (number < 0 || number > 7)
    {
        Console.WriteLine($"Day {number} is not a day of the week (there are 7 days in a week(enter a number from 1 to 7))");
    }
    else 
    {
        if (number > 0 && number < 6)
        {
            Console.WriteLine($"No, day {number} is not Weekend");
        }
        else Console.WriteLine($"Yes, day {number} is Weekend");
    }
}

Console.WriteLine("Enter any number: ");
int userNum = Convert.ToInt32(Console.ReadLine());
Weekend(userNum); 
*/

//Вариант 2 (работает с любыми числами)

/*
void Weekend (int number)
{
    if (number > 5 && number < 8)
    {
        Console.WriteLine($"Yes, day {number} is Weekend");
    }
    else 
    {
        if (number > 0 && number < 6)
        {
            Console.WriteLine($"No, day {number} is not Weekend");
        }
        else Console.WriteLine($"Day {number} is not a day of the week (there are 7 days in a week(enter a number from 1 to 7))");
    }
}

Console.WriteLine("Enter any number: ");
int userNum = Convert.ToInt32(Console.ReadLine());
Weekend(userNum);
*/