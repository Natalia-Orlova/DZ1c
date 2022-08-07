//  Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.Write($"Максимальное число = {num1}, минимальное число = {num2}");
}
else if (num2 > num1)
{
    Console.Write($"Максимальное число = {num2}, минимальное число = {num1}");
}
else
{
    Console.Write($"Введенные числа равны");
}