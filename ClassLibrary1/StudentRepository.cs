using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class StudentRepository
    {
        private List<Student> studentList = new List<Student>();
        private StudentIdGenerator idGenerator = StudentIdGenerator.Instance;        
        private static StudentRepository instance = null;
        private StudentRepository() { }
        public static StudentRepository Instance()
        {
            if (instance == null)
            {
                instance = new StudentRepository();
            }
            return instance;
        }
        //method for add student
        public void AddStudent( string name, string lastName, string gpa)
        {
            studentList.Add(new Student()
            { FirstName = name, LastName = lastName, Gpa = gpa, Id = idGenerator.GetId() });
        }          
        public List<Student> GetStudents()
        {
            studentList = studentList.OrderBy(x => x.LastName).ToList();
            return studentList;
        }
    }
}