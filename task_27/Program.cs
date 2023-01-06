// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.

Console.Write("введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (n > 0)
{
    sum += n % 10;
    n = n / 10;
}
Console.WriteLine($"сумма цифр вашего числа = {sum}");
