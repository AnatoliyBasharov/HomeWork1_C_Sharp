// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите первое число ");
string NumberOne = Console.ReadLine();
Console.WriteLine("Введите второе число ");
string NumberTwo = Console.ReadLine();
Console.WriteLine("Введите третье число ");
string NumberThree = Console.ReadLine();
int a = Convert.ToInt32(NumberOne);
int b = Convert.ToInt32(NumberTwo);
int c = Convert.ToInt32(NumberThree);
int sum = a;
if(a > b)
if(a > c)
{   
Console.WriteLine($"Максимальное число {a}");
} 
if(b > a)
if(b > c)
{
    Console.WriteLine($"Максимальное число {b}"); 

}
if(c > a)
if(c > b){
    Console.WriteLine($"Максимальное число {c}"); 

}

