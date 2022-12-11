// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine ("Считаем сумму цифр в введённом вами целом числе");
Console.Write ("Введите ваше число (не более 9 знаков)=> ");
int number = Math.Abs(Int32.Parse(Console.ReadLine()));
int result =0;

while (number>=1) {
    result +=number%10;
    number /=10;
    }

Console.WriteLine ($"Сумма цифр в вашем числе составляет: {result}");