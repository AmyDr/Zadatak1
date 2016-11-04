using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Code
{
    //validation class with methods to validate string (null or empty), operation name and GPA's appropriate data type
    public class Validation
    {
        public static string Validation(string s)
        {
            if (String.IsNullOrEmpty(s))
                return "is null or empty";
            else
            { }
        }
    }
}