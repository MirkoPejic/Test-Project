using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public class Validation
    {
        public static bool ValidateGpa(string gpa)
        {
            bool Result;
            double Number = -1;
            Result = double.TryParse(gpa, out Number);
            return Result;
        }
    }   
}