/*
Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

void Task27()
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Сумма цифр в числе {number} равна {FindSumNumbers(number)}");
}
int FindSumNumbers(int number)
{
    int SumNumber = 0;
    while (number > 0)
    {
        
        SumNumber = SumNumber + number%10;
        number = number/10;
    }
    return SumNumber;
}

Task27();

