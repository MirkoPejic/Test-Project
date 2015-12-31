using System;
using ClassLibrary1;


namespace Test_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string Operation; // local variable
            
            do
            {
                // loop to enter method
                do
                {
                    Console.WriteLine("Operation: ENLIST or DISPLAY ");
                    Console.Write("Operation: ");

                    Operation = Console.ReadLine().ToUpper(); // adjust for case sensitive 
                    if (Operation != Operations.Enlist && Operation != Operations.Display)
                    {
                        Console.WriteLine("Operation non-existing, please use appropriate operation.");
                    }
                    else
                    {
                        break;
                    }
                } while (Operation != Operations.Enlist && Operation != Operations.Display);

                //if the choice enlist
                if (Operation == Operations.Enlist)
                {
                    Console.WriteLine("Student");
                    UnosIspisManipuliranje.ENLIST();
                }
            } while (Operation == Operations.Enlist);

            //if the choice display
            if (Operation == Operations.Display)
            {                
                UnosIspisManipuliranje.DISPLAY();
            }
            
            Console.ReadKey();
        }
    }
}



