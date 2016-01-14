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
        //method add student to list
        public static void AddStudentToList( string name, string lastName, string gpa)
        {
            StudentContainer.Add(new Student()
            { FirstName = name, LastName = lastName, Gpa = gpa, Id = Id.GetId() });
        }          
        public static void SortList()
        {   //sorting list by last name
            StudentContainer.Sort((x, y) => string.Compare(x.LastName, y.LastName));
        }
        public static List<Student> ReturnList()
        {
            SortList();
            return StudentContainer;
        }
    }
}