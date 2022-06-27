// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.Write("Введите число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());

while (day > 7 ^ day < 1)
{
    Console.Write("Да, я тоже хочу дополнительный выходной, но число по-прежнему приму лишь от 1 до 7: ");
    day = Convert.ToInt32(Console.ReadLine());
}
if (day > 5)
{
    Console.Write("Выходной");
}
else
{
    Console.Write("No");
}