// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
// 456 -> 5
// 782 -> 8 
// 918 -> 1

int Remainder(int number)
{
    number = number % 10;
    return(number);
}

Console.Write("Введите число от 100 до 999: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 100 ^ number > 999)
{
    Console.Write("Я же написал - от 100 до 999. Три цифры! Давай заново, я в тебя верю: ");
    number = Convert.ToInt32(Console.ReadLine());
}

number = number % 100;

Console.WriteLine($"Вторая цифра введённого числа: {number / 10}");