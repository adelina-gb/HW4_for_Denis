/*
Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел
и выводит отсортированный по модулю массив.
-2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
6, 1, -33 -> [1, 6, -33]
*/

/*Random rand = new Random();
int number = rand.Next();
Console.WriteLine(number);*/

void Task29()
{
    int size = 8;
    int [] array = new int[size];
    array = FillArrayFunction(size);

    PrintArray(array);
    Sort(array);
}

int [] FillArrayFunction(int size)
{
    int [] fillArray = new int[size];
    Random random = new Random();
    for(int i = 0; i < fillArray.Length; i++)
    {
        fillArray[i] = random.Next(-100,101);
    }
    return fillArray;
}

void PrintArray(int [] array)
{
    Console.WriteLine("Вывод массива ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void Sort(int [] array)
{
    
    for(int i = 0; i < array.Length -1; i++)
    {
        if(array[i]<0)
        {
            array[i] = Math.Abs(array[i]);
        }
        int minPosition = i;
       
        for(int j = i +1; j < array.Length; j++)
        {
            if(array[j]<0)
            {
            array[j] = Math.Abs(array[j]);
            }
            
            if(array[j] < array[minPosition])
            {
                minPosition=j;
            }
        }    
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
        }
Console.WriteLine("Вывод отсортированного массива");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
}

Task29();