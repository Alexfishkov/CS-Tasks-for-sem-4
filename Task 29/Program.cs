// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем
// Дополнительно упорядочиваем массив по возрастанию и убыванию

int[] ourarray = new int[8];

void Printarray (int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine ();
}

void AscendArrange (int[] array)
{
    for (int i=0; i<array.Length-1; i++)
    {
        int Minposition =i;
        for (int j=i+1; j<array.Length; j++)
        {
            if (array [j] < array [Minposition]) Minposition = j;
        }
        int temporary = array [i];
        array [i] = array [Minposition];
        array [Minposition] = temporary;
    }
}

void DescendArrange (int[] array)
{
    for (int i=0; i<array.Length-1; i++)
    {
        int Maxposition =i;
        for (int j=i+1; j<array.Length; j++)
        {
            if (array [j] > array [Maxposition]) Maxposition = j;
        }
        int temporary = array [i];
        array [i] = array [Maxposition];
        array [Maxposition] = temporary;
    }
}

Console.Clear();
Console.WriteLine ("Просим ввести 8 элементов массива");
for (int ii=0; ii < ourarray.Length; ii++)
{
    Console.Write ($"Введите {ii+1} -й элемент массива =>");
    ourarray[ii] = Int32.Parse(Console.ReadLine());
}

Console.WriteLine("Исходный массив:");
Printarray(ourarray);
Console.WriteLine("Упорядочили по возрастанию:");
AscendArrange(ourarray);
Printarray(ourarray);
Console.WriteLine("Упорядочили по убыванию:");
DescendArrange(ourarray);
Printarray(ourarray);

