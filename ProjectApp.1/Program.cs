using System;
using Project.Code;

namespace Project.App
//everything related to the console's input/output
{
    public class Program
    {
        public static void Main(string[] args)
        {

            StudentContainer student = StudentContainer.Instance(); //deklaracija studenta

            string firstName;
            string lastName;
            string gpa;
            string operation;
            bool validateOperation;
            bool validateString;
            bool result;
           
            do
            {

                do
                {
                    Console.WriteLine("Please, type in your prefered operation");
                    Console.WriteLine("Your operation is: ");
                    operation = Console.ReadLine().ToUpper(); //enforce case-insensitive operation
                    validateOperation = Validation.ValidateOperation(operation);
                    if (validateOperation)
                    {
                        Console.WriteLine("Operation is not recognized");
                    }
                    else
                    {
                        break;
                    }
                } while (true);

                if (operation == Operations.Enlist)
                {
                    Console.WriteLine("Enlist new student");
                    do
                    {
                        Console.Write("Student's first name is: ");
                        firstName = Console.ReadLine(); //sprema vrijednost u varijablu firstName
                        validateString = Validation.ValidateString(firstName); //validacija provjerava firstName vrijednost
                        if (validateString)
                        {
                            Console.WriteLine("You need to insert value");
                        }
                        else
                        {
                            break;//ako je u redu ide na sljedeći unos
                        }
                    } while (true); //ponavlja se unos dok se ne upiše nešto

                    do
                    {
                        Console.Write("Student's last name is: ");
                        lastName = Console.ReadLine();
                        validateString = Validation.ValidateString(lastName);
                        if (validateString)
                        {
                            Console.WriteLine("You need to insert value");
                        }
                        else
                        {
                            break;
                        }
                    } while (true);

                    do
                    {
                        Console.Write("Student's GPA is: ");
                        gpa = Console.ReadLine();
                        result = Validation.ValidateGpa(gpa);
                        if (string.IsNullOrEmpty(gpa))
                        {
                            Console.WriteLine("You need to insert value");
                        }
                        else if (!result)
                        {
                            Console.WriteLine("You need to insert numerical value");
                        }
                        else
                        {
                            break;
                        }
                    } while (true);

                    student.AddStudent(firstName, lastName, gpa);
                }
                else
                {
                    break;
                }
            } while (true);


            if (operation == Operations.Display)
            {
                Console.WriteLine("Enlisted students");
                if (student.GetStudents().Count < 1)
                {
                    Console.WriteLine("There are no enlisted students");

                }
                else

                {
                    foreach (Student st in student.GetStudents())
                    {
                        Console.WriteLine("{0}. {1}, {2}, {3}", st.Id, st.LastName, st.FirstName, st.Gpa);
                    }

                }
            }
            Console.ReadKey();
        }
     }
}