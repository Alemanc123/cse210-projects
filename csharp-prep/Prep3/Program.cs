using System;

class Program
{
    static void Main(string[] args)
    {
        //when the user is aked for the number
        //Console.Write("What is your magic number? ");
        //string magicNumber = Console.ReadLine(); 
        ///Console.Write( "What is your guess? ");
        //string guess = Console.ReadLine();
        //int magicNumberInt = int.Parse(magicNumber);
        //nt guessInt = int.Parse(guess);

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 50);
        Console.WriteLine("Find a number between 1 and 50");
        
        
        int guess = -1;

        while (magicNumber != guess )
        {
            Console.Write("What is your guess? ");

            guess = int.Parse(Console.ReadLine()); 
            

        if (magicNumber > guess)
        {
            Console.WriteLine("Higher");    
        }
        else if (magicNumber < guess)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        } 
            
        }





        


    }
}