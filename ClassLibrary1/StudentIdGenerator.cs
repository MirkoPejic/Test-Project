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
        private StudentIdGenerator() { }
        public static StudentIdGenerator Instance
        {
            get
            {                
                if(instance == null)
                {
                    instance = new StudentIdGenerator();
                }
                return instance;                
            }
        }
        //unique id
        private int i = 1000;
        public int GetId()
        {
            return i++;
        }
    }
}