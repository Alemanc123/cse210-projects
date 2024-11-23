using System;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();

        int number = -1;

        while (number != 0)

        {
            Console.Write("Enter a list of number, type 0 when finished ");

            string newNumber = Console.ReadLine();

            number = int.Parse(newNumber);

            if (number != 0)
            {
                numbers.Add(number);
            }

        }


        // Additional code can go here to process the list (e.g., display, sum, etc.)
        Console.WriteLine("You entered the following numbers:");

        int sum = 0;

        foreach (int num in numbers)
        {
            Console.WriteLine("Enter number:" + num );
              sum += num; 
        }

            Console.WriteLine($"The sum is: {sum}");

            float average = ((float)sum)/numbers.Count;

            Console.WriteLine($"The average is: {average}");

            int max = numbers.Max();

            Console.WriteLine($"The largest number is: {max}");

           
        


    }
}