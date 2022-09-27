/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

void PrintArray(int[] collection)             
{
    int count = collection.Length;
    int position = 0;
    while (position < count - 1)
    {
        Console.Write($"{collection[position]}, ");
        position++;
    }
    Console.Write(collection[position]);
}

int [] array = new int[8];
int i = 0;

while (i < array.Length)
{
    array[i] = new Random().Next(0,101);
    i++;
}
PrintArray(array);
Console.Write(" -> [");
for (int index = 0; index < array.Length - 1; index++) Console.Write($"{array[index]}, ");
Console.Write($"{array[i-1]}]");


