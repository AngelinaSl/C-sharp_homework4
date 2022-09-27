/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

// Решение через while:

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int mult = 1;
int i = 0;
while (i < B)
{
    mult = mult * A;
    i++;
}
Console.WriteLine($"{A}^{B} = {mult}");

// Решение через for + random:

// int A = new Random().Next(1, 11);  
// Console.WriteLine($"Число А = {A};");
// int B = new Random().Next(1, 11);  
// Console.WriteLine($"Число B = {B};");
// int mult = 1;

// for (int i = 0; i < B; i++)
// {
//     mult = mult * A;
// }
// Console.WriteLine($"{A}^{B} = {mult}");

