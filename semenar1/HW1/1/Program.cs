// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
string Number1 = Console.ReadLine()!;
Console.WriteLine("Введите второе число");
string Number2 = Console.ReadLine()!;
int NumberInt1=Convert.ToInt32(Number1);
int NumberInt2=Convert.ToInt32(Number2);
if (NumberInt1 > NumberInt2)
    {
    Console.WriteLine("Первое число больше второго числа.");
    }
else if (NumberInt1 < NumberInt2)
    {
    Console.WriteLine("Второе число больше первого числа.");
    }
 else 
    {
    Console.WriteLine("Введны одинаковые числа.");
    }
