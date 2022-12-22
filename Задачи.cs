/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
/*
int DeGree (int x, int n)
{
    int result = x;
    int count = 2;
    for(count=2; count<=n; count++)
    {
        result = result * x;
    }
    return result;
}

Console.WriteLine("Введите число А:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int b = Convert.ToInt32(Console.ReadLine());
int result = DeGree(a,b);
Console.WriteLine(result);
*/

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму 
цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/
/*
int Sum (int num)
{
    int result = 0;
    while (num>0)
    {
        result = result + num%10 ;
        num = num/10;
    }
    return result;
}

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int result = Sum(N);
Console.WriteLine(result);
*/

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] CreateRandomArray (int size,int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for(int i=0;i<size;i++)
    {
        myArray[i] = new Random().Next(minValue,maxValue+1);
    }
    return myArray;
}

void ShowArray (int[] array)
{
    Console.WriteLine("Полученный массив ->:");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите размер массива:");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение элемента массива:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива:");
int max = Convert.ToInt32(Console.ReadLine());

ShowArray(CreateRandomArray(lenght,min,max));