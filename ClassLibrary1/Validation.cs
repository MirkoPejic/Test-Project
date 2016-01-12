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
        #region LocalVariables
        private static bool Rezultat;
        private static double Number = -1; 
        #endregion


        #region MethodValidateGpa
        public static bool ValidateGpa(string gpa)
        {
            Rezultat = double.TryParse(gpa, out Number);
            return Rezultat;
        } 
        #endregion



    }
}