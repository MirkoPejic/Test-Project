using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class StudentRepository
    {
        private List<Student> StudentList = new List<Student>();
        private StudentIdGenerator GeneratedId = StudentIdGenerator.IdGenerator;        
        private static StudentRepository StudentObject = null;
        private StudentRepository() { }
        public static StudentRepository GetStudentObject()
        {
            if (StudentObject == null)
            {
                StudentObject = new StudentRepository();
            }
            return StudentObject;
        }
        //method for add student
        public void AddStudent( string name, string lastName, string gpa)
        {
            StudentList.Add(new Student()
            { FirstName = name, LastName = lastName, Gpa = gpa, Id = GeneratedId.GetId() });
        }          
        public List<Student> ReturnStudentList()
        {
            StudentList = StudentList.OrderBy(x => x.LastName).ToList();
            return StudentList;
        }
    }
}