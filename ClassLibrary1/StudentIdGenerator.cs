using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class StudentIdGenerator
    {
        private static StudentIdGenerator Instances = null;
        private static readonly object Id = new object();
        StudentIdGenerator() { }
        public static StudentIdGenerator Instance
        {
            get
            {                
                if(Instances == null)
                {
                    Instances = new StudentIdGenerator();
                }
                return Instances;                
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
