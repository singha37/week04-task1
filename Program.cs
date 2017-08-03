using System;

namespace week04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();
            
                

            Console.WriteLine("What is your firstname");
            var firstname = Console.ReadLine();

            Console.WriteLine("What is your lastname");
            var lastname = Console.ReadLine();

            Console.WriteLine(firstname + lastname);  
            
            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        }
    }
}
