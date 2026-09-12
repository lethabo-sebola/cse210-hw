using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        // 1. Compute the sum of the numbers
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum of the numbers is: {sum}");

        // 2. Compute the average of the numbers
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average of the numbers is: {average}");

        // 3. Find the largest number
        int largest = numbers[0];
        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");

        // 4. Find the smallest positive number
        int smallestPositive = int.MaxValue;
        foreach (int num in numbers)
        {
            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // 5. Sort the list
        numbers.Sort();
        Console.WriteLine("The sorted list of numbers is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}