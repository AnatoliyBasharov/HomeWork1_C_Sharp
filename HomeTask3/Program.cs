// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).



Console.WriteLine("Введите число ");
string InputNumber = Console.ReadLine();
int Number = Convert.ToInt32(InputNumber);
int max = Number;
int temp = Number;
if(Number % 2 == 0)
{
Console.WriteLine($" Ого,это число {Number} и в правду является четным!");
}
if(temp % 2 != 0)
{
 Console.WriteLine($"О нет, это число {temp} не является четным :(");   
}


