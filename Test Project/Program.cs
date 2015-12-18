using System;
using ClassLibrary1;


namespace Test_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation; // local variable 
            
            do
            {
                // loop to enter method
                do
                {
                    Console.WriteLine("Operation: ENLIST or DISPLAY ");
                    Console.Write("Operation: ");

                    operation = Console.ReadLine().ToUpper(); // adjust for case sensitive 
                    if (operation != "ENLIST" && operation != "DISPLAY")
                        Console.WriteLine("Operation non-existing, please use appropriate operation.");
                } while (operation != "ENLIST" && operation != "DISPLAY");

                //if the choice enlist
                if (operation == "ENLIST")
                {
                    Console.WriteLine("Student");
                    Operations.ENLIST();
                }
            } while (operation == "ENLIST");

            //if the choice display
            if (operation == "DISPLAY")
            {                
                Operations.DISPLAY();
            }
            
            Console.ReadKey();
        }
    }
}



