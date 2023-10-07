// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество элементов:\t");
int count=int.Parse(Console.ReadLine());
int[] array=new int[count];
Console.WriteLine("Введите массив");
for (int i = 0; i < array.Length; i++)
{
    array[i]=int.Parse(Console.ReadLine());
}

// Console.WriteLine("Вывод массива");
// for (int i = 0; i < array.Length; i++)
// {
//     Console.WriteLine(array[i]);
// }

int negative=0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]>0)
    {
        negative++;
    }
    
}
Console.WriteLine($"Количество положительных элементов: {negative}");