// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!

Console.Clear();
Console.WriteLine ("Возводим число А в степень В");
Console.Write ("Введите число А=>");
int numberA = Int32.Parse(Console.ReadLine());
int numberB = -1;

while (numberB<0) {
Console.Write ("Введите натуральное число (или 0) B=>");
numberB = Int32.Parse(Console.ReadLine());
if (numberB>=0) break;
Console.WriteLine ("Ввод некорректный! Введите натуральное число B=>");
}

double result = 1;
for (int i=1; i<= numberB; i++)
{
    result *=numberA;
}

Console.Clear();
Console.WriteLine ($"{numberA} в степени {numberB} = {result}" );

