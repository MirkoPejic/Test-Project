using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary1
{
    public class Validation : Exception
    {
        // exception, insert value
        public static void ValidateString()
        {

            try
            {
                throw new Validation("You need to insert value.");
            }
            catch (Validation ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        // exception, numerical value
        public static void ValidateGpa()
        {
            try
            {
                throw new Validation("You need to insert numerical value.");
            }
            catch (Validation ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public Validation() : base()
        {

        }
        public Validation(string message) : base(message)
        {

        }

    }
}
