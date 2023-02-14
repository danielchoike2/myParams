using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the amount of numbers you will be adding & multiplying today.");
        int size = Convert.ToInt32(Console.In.ReadLine());
        int[] numbers = new int[size];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Please enter a number");
            numbers[i] = Convert.ToInt32(Console.In.ReadLine());
        }
        Console.WriteLine($"Total of the numbers entered ={Add(numbers)}");
        Console.WriteLine($"Product of the numbers entered ={Mult(numbers)}");



    }
    static int Add(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }

    static int Mult(params int[] numbers)
    {
        int total = 1;
        foreach (int number in numbers)
        {
            total *= number;
        }
        return total;
    }

}
