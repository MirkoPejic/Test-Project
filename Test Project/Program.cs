using System;
using ClassLibrary1;


namespace Test_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LocalVariables
            string Operation;
            string OperationNonExist = "Operation non-existing, please use appropriate operation.";              
            #endregion

            do
            {
                // loop to enter method
                #region InputMethod-Enlist-Or-Display
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
                } while (Operation != Operations.Enlist && Operation != Operations.Display); 
                #endregion

                //if the choice enlist
                #region ChoiceIsEnlist
                if (Operation == Operations.Enlist)
            {
                Console.WriteLine("Student");

                    #region CheckingName
                    StudentRepository.EnlistName();
                    while (string.IsNullOrEmpty(StudentRepository.Name))
                    {
                        Console.WriteLine(StudentRepository.InsertValue);
                        StudentRepository.EnlistName();
                    }
                    #endregion

                    #region CheckingLastName
                    StudentRepository.EnlistLastName();
                    while (string.IsNullOrEmpty(StudentRepository.Last))
                    {
                        Console.WriteLine(StudentRepository.InsertValue);
                        StudentRepository.EnlistLastName();
                    }
                    #endregion


                    #region CheckingGpa
                    StudentRepository.EnlistGpa();
                    while ((string.IsNullOrEmpty(StudentRepository.Gpa)) || (!StudentRepository.Result))
                    {
                        if (string.IsNullOrEmpty(StudentRepository.Gpa))
                        {
                            Console.WriteLine(StudentRepository.InsertValue);
                            StudentRepository.EnlistGpa();
                        }
                        else if (!StudentRepository.Result)
                        {
                            Console.WriteLine(StudentRepository.NumericalValue);
                            StudentRepository.EnlistGpa();
                        }
                        else
                        {
                            break;
                        }
                    }
                    #endregion

                    #region AddStudentToList
                    StudentRepository.AddStudentValues(); 
                    #endregion
                }
        } while (Operation == Operations.Enlist);
        #endregion

            //if the choice display
            #region ChoiceIsDisplay
            if (Operation == Operations.Display)
            {

                StudentRepository.Sort();
                StudentRepository.Print();

            } 
            #endregion

            Console.ReadKey();
        }
    }
}



