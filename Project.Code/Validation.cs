using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Code
{
    //validation class with methods to validate string (null or empty), operation name and GPA's appropriate data type
    public class Validation
    {
        public static bool ValidateString(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;
            else
                return false;
        }

        public static bool ValidateGpa(string gpa)
        {
            bool result;
            double number;
            result = double.TryParse(gpa, out number);
            return result;
        }

        public static bool ValidateOperation(string operation)
        {
            if (operation != Operations.Enlist && operation != Operations.Display)
                return true;
            else
                return false;
        }
    }
}