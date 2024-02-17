using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        // Prompting user for the number of values to generate
        Console.WriteLine("How many random numbers would you like to generate?");
        int size = int.Parse(Console.ReadLine());

        // Creating an array to store the random numbers
        int[] numbers = new int[size];

        // Filling the array with random numbers
        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(1, 10);
        }

        // Printing out the random numbers
        Console.WriteLine("\nRandom Numbers:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine(); // Adding a newline for formatting

        // Calculating the total using the Add method
        int totalAdd = Add(numbers);
        Console.WriteLine($"the Total from the Add method = {totalAdd}");

        // Calculating the product using the Multiply method
        int totalMultiply = Multiply(numbers);
        Console.WriteLine($"the Product from the Multiply method = {totalMultiply}");

    }

    // Add method to calculate the sum of an array of integers
    static int Add(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }

    // Multiply method to calculate the product of an array of integers
    static int Multiply(params int[] numbers)
    {
        int total = 1; // Initialize total to 1
        foreach (int number in numbers)
        {
            total *= number;
        }
        return total;
    }
}
