// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Remainder(int number)
{
    number = number % 10;
    return(number);
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number < 100)
{
    Console.Write("Третьей цифры, в заданном числе нет");    
}
else
{
    while (number > 999)
    {
        number = number / 10;
    }
    Console.WriteLine($"Третья цифра в заданном числе: {Remainder(number)}");
}