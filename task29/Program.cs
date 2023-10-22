// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] randomArray = new int[8];             //Выдает 8 случайных чисел

for (int i = 0; i < 8; i++)
{
randomArray[i] = new Random().Next(1,99);   // диапазон случайных чисел от 1 до 99
Console.Write(randomArray[i] + " ");        // результат
}