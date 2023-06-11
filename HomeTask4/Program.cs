// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.



Console.WriteLine("Введите число ");
string number = Console.ReadLine();
int N = Convert.ToInt32(number);
int temp = 0;
while(temp < N)
{ 
    temp++;
    if(temp % 2 ==0)
{
Console.Write($" {temp}");
}
    
}


