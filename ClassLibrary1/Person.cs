using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibrary1
{

    public abstract class Person
    {
        public abstract string FirstName { get; set; }
        public abstract string LastName { get; set; }

        public abstract int ID { get; set; }
    }
}

