// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int number = ReadInt("Введите число: ");
int len = NumberLen(number);
SumNumbers(number, len);

int ReadInt(string message) // Функция ввода
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int NumberLen(int a) // Функция подсчета цифр в числе
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}
void SumNumbers(int n, int len) // Функция вывода суммы цифр в числе
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.Write($"Сумма цифр в числе {number} равно: {sum}");
}