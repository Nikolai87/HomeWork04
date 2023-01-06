// Напишите цикл, который на вход принимает два числа (A и B) и возводит число А в натуральную степень В.

Console.Write("введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = a;

for (int i = 1; i < b; i++)
{
    result = result * a;
}

Console.WriteLine("A в натуральной степени B равно: " + result);

