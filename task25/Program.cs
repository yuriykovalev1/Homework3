// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

Console.WriteLine("введите число A");           // вводим первое число
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите степень числа А");   // вводим степень числа
int b = Convert.ToInt32(Console.ReadLine());
int stepen = a;
if (b < 1)
    Console.Write("Степень должна быть натуральным\n");     // если степень 0
else
{
    for (int i = 1; i < b; i++)                             // возводим в степень
    {
        stepen = stepen * a;
        Console.WriteLine("A в степени B равно: " + stepen);
    }
}