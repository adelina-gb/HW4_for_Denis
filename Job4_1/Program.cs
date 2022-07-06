/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

void Task25()
{
Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
numberB = Math.Abs(numberB);

Console.WriteLine($"Число {numberA} в степени {numberB} равно {Exponentiation(numberA, numberB)}");
}

int Exponentiation(int numberA, int numberB)
{
    int result = 1;
    for(int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}
Task25();

