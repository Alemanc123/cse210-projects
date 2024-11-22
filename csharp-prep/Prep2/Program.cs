using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int percentageInt = int.Parse(percentage);


        string letter = "";
    

        if (percentageInt >= 90)
        { 
            letter = "A";
            
        } 
        
        else if (percentageInt >= 80)
        {
            letter = "B";
        }
        else if (percentageInt >= 70)
        {
            letter = "C";
        }
        else if (percentageInt >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        if (letter == "D" || letter == "F")

        {
            Console.Write( $"Your letter grade is: {letter}, better luck next time.");
        }
        else
        {
            Console.Write( $"Your letter grade is: {letter}, congratulations! you passed the course.");
        }

    }   






}
