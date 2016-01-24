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
            bool result;
            double number = -1;
            result = double.TryParse(gpa, out number);
            return result;
        }
    }   
}