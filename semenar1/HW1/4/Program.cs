//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
string Number=Console.ReadLine()!;
int NumberInt=Convert.ToInt32(Number);
int NumberBegin=1;
 if (NumberInt<NumberBegin)
     {
     Console.Write("Число должно быть больше ");
     Console.Write(NumberBegin);
     }
     Console.WriteLine("Четные числа: ");
while (NumberBegin<=NumberInt)
{
   int Remainder=NumberBegin%2;
    if (Remainder==0) 
        {
            Console.WriteLine(NumberBegin);
        }
   NumberBegin=NumberBegin+1;
}