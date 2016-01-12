using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class StudentRepository
    {
        public static List<Student> StudentContainer = new List<Student>();
        private static StudentIdGenerator Id = StudentIdGenerator.Instance;
        
        #region LocalVariables        
        public static string Name;
        public static string Last;
        public static string Gpa;
        public static string InsertValue = "You need to insert value.";
        public static string NumericalValue = "You need to insert numerical value.";
        public static bool Result;
        #endregion

        #region InputStudents

            #region MethodInputName
            public static void EnlistName()
            {
                Console.Write("First Name: ");
                Name = Console.ReadLine().Trim();
            }
            #endregion

            #region MethodInputLastName
            public static void EnlistLastName()
            {
                Console.Write("Last Name: ");
                Last = Console.ReadLine().Trim();
            }
            #endregion

            #region MethodInputGpa
            public static void EnlistGpa()
            {
                Console.Write("GPA: ");
                Gpa = Console.ReadLine().Trim();
                Result = Validation.ValidateGpa(Gpa);
            }
            #endregion

            #region Method-Creating-Student-With-Entered-Values-And-Adding-Id
            public static void AddStudentValues()
            {
                StudentContainer.Add(new Student()
                { FirstName = Name, LastName = Last, Gpa = Gpa, Id = Id.GetId() });
            }
            #endregion

        #endregion


        #region MethodsForManipulating

            #region MethodForSort
            public static void Sort()
            {   // sorting list by last name
                StudentContainer.Sort((x, y) => string.Compare(x.LastName, y.LastName));
            }
            #endregion

            #region MethodForPrint
            public static void Print()
            {
                int I = 1;
                if (!StudentContainer.Any())
                {
                    Console.WriteLine("List is empty!");
                }
                else
                {
                    Console.WriteLine("Students in a system:");
                    // loop for printig list
                    foreach (Student St in StudentContainer)
                    {
                        Console.WriteLine("{0}. {1}, {2} - {3}", I, St.LastName, St.FirstName, St.Gpa);
                        //Console.WriteLine("ID: {0}", St.Id);
                        I++;
                    }
                }
            }
            #endregion 
        #endregion
    }
}