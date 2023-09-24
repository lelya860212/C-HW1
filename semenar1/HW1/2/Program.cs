// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число");
string Number1 = Console.ReadLine()!;
Console.WriteLine("Введите второе число");
string Number2 = Console.ReadLine()!;
Console.WriteLine("Введите третье число");
string Number3 = Console.ReadLine()!;
int NumberInt1=Convert.ToInt32(Number1);
int NumberInt2=Convert.ToInt32(Number2);
int NumberInt3=Convert.ToInt32(Number3);
int MaxNumber=NumberInt1;
if (NumberInt2 > MaxNumber)
    {
    MaxNumber=NumberInt2;
    }
if (NumberInt3 > MaxNumber)
    {
    MaxNumber=NumberInt3;
    }
Console.WriteLine("Максимальное число равно");
Console.WriteLine(MaxNumber);
