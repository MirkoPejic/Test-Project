using System;
using ClassLibrary1;

namespace Test_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentRepository Student = StudentRepository.GetStudentObject();
            string Operation;
            string Name;
            string LastName;
            string Gpa;
            bool Result;
            const string InsertValue = "You need to insert value.";
            const string NumericalValue = "You need to insert numerical value.";
            const string OperationNonExist = "Operation non-existing, please use appropriate operation.";
            do
            {
                //loop to enter method
                do
                {
                    Console.WriteLine("Operation: ENLIST or DISPLAY ");
                    Console.Write("Operation: ");
                    Operation = Console.ReadLine().ToUpper(); // adjust for case sensitive 
                    if (Operation != Operations.Enlist && Operation != Operations.Display)
                    {
                        Console.WriteLine(OperationNonExist);
                    }
                    else
                    {
                        break;
                    }
                } while (true);
                //if the choice enlist
                if (Operation == Operations.Enlist)
                {
                    Console.WriteLine("Student");
                    //input name
                    do
                    {
                        Console.Write("First Name: ");
                        Name = Console.ReadLine().Trim();
                        if (string.IsNullOrEmpty(Name))
                        {
                            Console.WriteLine(InsertValue);
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
                        LastName = Console.ReadLine().Trim();
                        if (string.IsNullOrEmpty(LastName))
                        {
                            Console.WriteLine(InsertValue);
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
                        Gpa = Console.ReadLine().Trim();
                        Result = Validation.ValidateGpa(Gpa);
                        if (string.IsNullOrEmpty(Gpa))
                        {
                            Console.WriteLine(InsertValue);
                        }
                        else if (!Result)
                        {
                            Console.WriteLine(NumericalValue);
                        }
                        else
                        {
                            break;
                        }
                    } while (true);
                    Student.AddStudent(Name, LastName, Gpa);
                }
            } while (Operation == Operations.Enlist);
            //if the choice display
            if (Operation == Operations.Display)
            {
                Console.WriteLine("Students in a system:");
                //loop for printig list
                if (Student.ReturnStudentList().Count < 1)
                {
                    Console.WriteLine("List is empty!");
                }
                else
                {
                    int I = 1;
                    foreach (Student St in Student.ReturnStudentList())
                    {
                        Console.WriteLine("{0}. {1}, {2} - {3}", I, St.LastName, St.FirstName, St.Gpa);
                        Console.WriteLine("ID: {0}", St.Id);
                        I++;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}