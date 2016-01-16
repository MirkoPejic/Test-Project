using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class StudentIdGenerator
    {
        private static StudentIdGenerator PrivateIdGenerator = null;
        private StudentIdGenerator() { }
        public static StudentIdGenerator IdGenerator
        {
            get
            {                
                if(PrivateIdGenerator == null)
                {
                    PrivateIdGenerator = new StudentIdGenerator();
                }
                return PrivateIdGenerator;                
            }
        }
        //unique id
        private int I = 1000;
        public int GetId()
        {
            return I++;
        }
    }
}