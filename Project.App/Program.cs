using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Code;//upotreba klasa

namespace Project.App
//everything related to the console's input/output
{
    public class Program
    {
        public void Main(string[] args)
            //iz liste
        {
            string FirstName;
            string LastName;
            string Gpa;
            string operation;

            Console.WriteLine("Please, type in your prefered operation");
            Console.WriteLine("Your operation is: ");
            operation= Console.ReadLine().ToUpper(); //enforce case-insensitive operation
            if (operation == Operations.Enlist)
            {
                Console.WriteLine("First Name: ");
                Console.ReadLine();
                if 
                else
                    

            }
            else
            

            if(operation == Operations.Display)
            {

            }
        }
    }
}
