using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ClassLibrary1
{

    public static class Operations
    {
        // student container list
        static List<Student> StudentContainer = new List<Student>();
        
        // method enlist
        public static void ENLIST()
        {
            // local variables 
            string Name;
            string Last;
            string Gpa;
            //decimal number = -1;
            bool result;
            
            // instance of id generator
            StudentIdGenerator _id = StudentIdGenerator.Instance;

            // loop for student first name
            do
            {
                Console.Write("First Name: ");
                Name = Console.ReadLine().Trim();                
                if (string.IsNullOrEmpty(Name)) Validation.ValidateString();
            } while (string.IsNullOrEmpty(Name));

            // loop for student last name
            do
            {
                Console.Write("Last Name: ");
                Last = Console.ReadLine().Trim();                
                if (string.IsNullOrEmpty(Last)) Validation.ValidateString();
            } while (string.IsNullOrEmpty(Last));

            // loop for student grade point average
            do
            {
                double number = -1;
                Console.Write("GPA: ");
                Gpa =Console.ReadLine().Trim();
                result = double.TryParse(Gpa,  out number);
                if (string.IsNullOrEmpty(Gpa)) { Validation.ValidateString(); }
                else if (!result) Validation.ValidateGpa();
                
            } while ((string.IsNullOrEmpty(Gpa)) || (!result));

            // creating student with entered values and adding ID
            StudentContainer.Add(new Student()
            { FirstName = Name, LastName = Last, GPA = Gpa, ID = _id.getId() });



        }
        // method display
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

        // sort method
        public static void Sort()
        {   // sorting list by last name
            StudentContainer.Sort((x, y) => string.Compare(x.LastName, y.LastName));
        }
        // print method
        public static void Print()
        {
            int i = 1;
            Console.WriteLine("Students in a system:");
            // loop for printig list
            foreach (Student st in StudentContainer)
            {
                Console.WriteLine("{0}. {1}, {2} - {3}", i, st.LastName, st.FirstName, st.GPA);
                // Console.WriteLine("ID: {0}",st.ID);
                i++;
            }
        }
    }
}