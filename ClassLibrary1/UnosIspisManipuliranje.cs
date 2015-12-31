using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class UnosIspisManipuliranje
    {
        public static List<Student> StudentContainer = new List<Student>();

        #region LokalneVarijable
        // local variables 
        private static string Name;
        private static string Last;
        private static string Gpa;
        private static string InsertValue = "You need to insert value.";
        private static string NumericalValue = "You need to insert numerical value.";
        private static bool Result; 
        #endregion

        #region UnosStudenata
        public static void ENLIST() 
        
        {
            // instance of id generator
            StudentIdGenerator Id = StudentIdGenerator.Instance;

            // loop for student first name
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
            } while (string.IsNullOrEmpty(Name));

            // loop for student last name
            do
            {
                Console.Write("Last Name: ");
                Last = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(Last))
                {
                    Console.WriteLine(InsertValue);
                }
                else
                {
                    break;
                }
            } while (string.IsNullOrEmpty(Last));

            // loop for student grade point average
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
            } while ((string.IsNullOrEmpty(Gpa)) || (!Result));

            // creating student with entered values and adding ID
            StudentContainer.Add(new Student()
            { FirstName = Name, LastName = Last, GPA = Gpa, ID = Id.GetId() });
        }
        #endregion
        #region IspisStudenata
        public static void DISPLAY()
        {
            // checking list
            if (!StudentContainer.Any())
            {
                Console.WriteLine("List is empty!");
            }
            else
            {
                Sort();
                Print();
            }
        }
        #endregion

        #region MetodaZaSortiranje
        public static void Sort()
        {   // sorting list by last name
            StudentContainer.Sort((x, y) => string.Compare(x.LastName, y.LastName));
        }
        #endregion
        // print method
        #region MetodaZaIspis
        public static void Print()
        {
            int I = 1;
            Console.WriteLine("Students in a system:");
            // loop for printig list
            foreach (Student st in StudentContainer)
            {
                Console.WriteLine("{0}. {1}, {2} - {3}", I, st.LastName, st.FirstName, st.GPA);
                // Console.WriteLine("ID: {0}",st.ID);
                I++;
            }
        } 
        #endregion
    }
}
