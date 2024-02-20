﻿class Program
{
    static void Main(string[] args)
    {
        //ForLoop();
        //WhileLoop();
        //DoWhileLoop();
        //ForEachLoop();
        if (IsPrimeNumber(11))
        {
            Console.WriteLine("This is a prime number");
        }
        else
        {
            Console.WriteLine("This is a not prime number");
        }
    }

    private static bool IsPrimeNumber(int number)
    {
        bool result = true;
        for (int i = 2; i < number - 1; i++)
        {
            if (number%i==0)
            {
                result = false;
                i = number;
            }
        }
        return result;
    }
    private static void ForEachLoop()
    {
        string[] students = new string[] { "Engin", "Derin", "Talha" };
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }

    private static void DoWhileLoop()
    {
        int number = 10;
        do
        {
            Console.WriteLine(number);
            number--;

        } while (number>=0);
    }

    private static void WhileLoop()
    {
        int number = 100;
        while (number>=0)
        {
            Console.WriteLine(number);
            number--;
        }
        Console.WriteLine("Now Number is {0}",number);
    }

    private static void ForLoop()
    {
        for (int i = 100; i >= 0; i-=2)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Finished");
    }
}