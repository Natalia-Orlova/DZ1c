// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = 1;
Console.Write($"Четные числа из ряда от 1 до {num}:  ");
while (count <= num)
{
    if (count % 2 == 0)
    {
        Console.Write($" {count} ");
    }
   count++;
}



// или 2-й вариант:


// Console.WriteLine("Введите натуральное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int count = 0;
// Console.Write($"Четные числа из ряда от 1 до {num}:  ");
// while (count < num - 1)

// {
//     count += 2;
//     Console.Write($" {count} ");
// }


