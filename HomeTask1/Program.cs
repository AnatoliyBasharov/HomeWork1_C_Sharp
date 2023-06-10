// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число ");
string NumberOne = Console.ReadLine();
Console.WriteLine("Введите второе число ");
string NumberTwo = Console.ReadLine();
int One = Convert.ToInt32(NumberOne);
int Two = Convert.ToInt32(NumberTwo);
if(One > Two)
{
    Console.WriteLine($"max = {One}");
    Console.WriteLine($"min = {Two}");
} else
{
    if(One < Two)
    {
    Console.WriteLine($"max = {Two}");
    Console.WriteLine($"min = {One}"); 
    }
}




