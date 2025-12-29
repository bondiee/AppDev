using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter how many numbers you want to average: ");
        int count = int.Parse(Console.ReadLine());

        double sum = 0;

        for (int i = 1; i <= count; i++)
        {
            Console.Write("Enter number " + i + ": ");
            double num = double.Parse(Console.ReadLine());
            sum += num;
        }

        double average = sum / count;

        Console.WriteLine("The average is: " + average);
    }
}
