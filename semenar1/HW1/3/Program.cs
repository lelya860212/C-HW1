//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число");
string Number1 = Console.ReadLine()!;
int NumberInt1=Convert.ToInt32(Number1);
int Remainder=NumberInt1%2;
 if (Remainder==0)
     {
     Console.WriteLine("Число является четным.");
     }
 else
   {
     Console.WriteLine("Число является нечетным.");
     }
