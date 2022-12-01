// Задача 2: Напишите программу, которая на вход принимает два числа и 
// выдаёт, какое число большее, а какое меньшее.
/*
int min = 0, max = 0;
Console.Write($"Введите первое положительное число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите второе положительное число: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}
Console.WriteLine($"Минимальное число - {min}");
Console.WriteLine($"Максимальное число - {max}");
*/


// Задача 4: Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.
/*
int a = 0, b = 0, max = 0;
Console.Write($"Введите первое число: ");
max = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите второе число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите третье число: ");
b = Convert.ToInt32(Console.ReadLine());
if(max < a)
{
    max = a;
}
if(max < b)
{
    max = b;
}
Console.WriteLine($"Максимальное число - {max}");
*/


// Задача 6: Напишите программу, которая на вход принимает число и 
// выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
int a = 0;
Console.Write($"Введите число: ");
a = Convert.ToInt32(Console.ReadLine());
if(a == 0)
{
    Console.WriteLine($"На 0 делить нельзя!");
}
else if(a % 2 == 0)
{
    Console.WriteLine($"Число {a} делится на 2");
}
else
{
    Console.WriteLine($"Число {a} не делится на 2");
}
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
/*
int a = 0;
string number = "";
Console.Write($"Введите число: ");
a = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= a; i++)
{
    if(i % 2 == 0)
    {
        if(i == a || i == a - 1)
        {
            number += Convert.ToString($"{i}");
        }
        else
        {
            number += Convert.ToString($"{i}, ");
        }
    }
}
Console.WriteLine($"{number}");
*/