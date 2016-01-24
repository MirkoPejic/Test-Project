using System;
using ClassLibrary1;

namespace Test_Project
{
    class Program
    {
        private class ErrorMessages
        {
            public const string InsertValue = "You need to insert value.";
            public const string NumericalValue = "You need to insert numerical value.";
            public const string OperationNonExist = "Operation non-existing, please use appropriate operation.";
        }
        static void Main(string[] args)
        {
            StudentRepository student = StudentRepository.Instance();
            string operation;
            string name;
            string lastName;
            string gpa;
            bool result;
            
            do
            {
                //loop to enter method
                do
                {
                    Console.WriteLine("Operation: ENLIST or DISPLAY ");
                    Console.Write("Operation: ");
                    operation = Console.ReadLine().ToUpper(); // adjust for case sensitive 
                    if (operation != Operations.Enlist && operation != Operations.Display)
                    {
                        Console.WriteLine(ErrorMessages.OperationNonExist);
                    }
                    else
                    {
                        break;
                    }
                } while (true);
                //if the choice enlist
                if (operation == Operations.Enlist)
                {
                    Console.WriteLine("Student");
                    //input name
                    do
                    {
                        Console.Write("First Name: ");
                        name = Console.ReadLine().Trim();
                        if (string.IsNullOrEmpty(name))
                        {
                            Console.WriteLine(ErrorMessages.InsertValue);
                        }
                        else
                        {
                            break;
                        }
                    } while (true);
                    //input last name
                    do
                    {
                        Console.Write("Last Name: ");
                        lastName = Console.ReadLine().Trim();
                        if (string.IsNullOrEmpty(lastName))
                        {
                            Console.WriteLine(ErrorMessages.InsertValue);
                        }
                        else
                        {
                            break;
                        }
                    } while (true);
                    //input gpa
                    do
                    {
                        Console.Write("GPA: ");
                        gpa = Console.ReadLine().Trim();
                        result = Validation.ValidateGpa(gpa);
                        if (string.IsNullOrEmpty(gpa))
                        {
                            Console.WriteLine(ErrorMessages.InsertValue);
                        }
                        else if (!result)
                        {
                            Console.WriteLine(ErrorMessages.NumericalValue);
                        }
                        else
                        {
                            break;
                        }
                    } while (true);
                    student.AddStudent(name, lastName, gpa);
                }
                else
                {
                    break;
                }
            } while (true);
            //if the choice display
            if (operation == Operations.Display)
            {
                Console.WriteLine("Students in a system:");
                //loop for printig list
                if (student.GetStudents().Count < 1)
                {
                    Console.WriteLine("List is empty!");
                }
                else
                {
                    int i = 1;
                    foreach (Student st in student.GetStudents())
                    {
                        Console.WriteLine("{0}. {1}, {2} - {3}", i, st.LastName, st.FirstName, st.Gpa);
                        Console.WriteLine("ID: {0}", st.Id);
                        i++;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}