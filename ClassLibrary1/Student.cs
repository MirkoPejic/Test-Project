using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibrary1
{

    public class Student : Person
    {
        private string _firstName;
        private string _lastName;
        private string _gpa;
        private int _id;
       
        public string GPA
        {
            get
            {
                return _gpa;
            }
            set
            {
                _gpa = value;
            }

        }
        public override string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }

        public override string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }

        public override int ID
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public void StudentContainer()
        {


        }

    }
}
