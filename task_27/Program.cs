/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int index = 0;
int y = x;
for (index = 0; y > 0; index++)   y = y / 10;
    
int[] array;  
array = new int[index];
int i = 0;
int l = x;
for (i = 0; i < index; i++)
{
    array[i] = l % 10;
    l /= 10;
}

int SumNumb (int[]arr) // сумма чисел массива
{
int i2 = 0;
int sum = 0;
while (i2 <= i - 1)
{
    sum = sum + arr[i2];
    i2++;
}
return sum;
}

int Sum = SumNumb(array);
Console.WriteLine($"Сумма цифр числа {x} = {Sum}");
