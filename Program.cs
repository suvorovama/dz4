/*Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16

Console.Write("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i <= secondNumber; i++)
{
    result = result * firstNumber;
}
Console.Write (result);

Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (number > 0)
{
    int num = number % 10;
    number = number / 10;
    sum += num;
}
Console.Write($"Сумма всех цифр в числе - {sum}");





