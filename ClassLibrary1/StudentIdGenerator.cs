using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class StudentIdGenerator
    {
        private static StudentIdGenerator instance = null;
        private static readonly object ID = new object();
        StudentIdGenerator()
        {                     
        }

        public static StudentIdGenerator Instance
        {
            get
            {
                lock (ID)
                {
                    if(instance == null)
                    {
                        instance = new StudentIdGenerator();
                    }
                    return instance;
                }
            }
        }
        // unique id
        private int i = 1000;
        public int getId()
        {
            return i++;
        }
    }
}
