using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Code
{
    // in-memory list of all students, and methods to manipulate that list
    public class StudentContainer
    {
        private List<Student> studentList = new List<Student>(); //kreiranje liste klase student
        private StudentIdGenerator studentIdGenerator; //definiranje generatora
        private static StudentContainer instance;
        public StudentContainer() {
            studentIdGenerator = StudentIdGenerator.getGenerator(); //instanciranje generatora
        }
        //singleton pattern za listu
        public static StudentContainer Instance()
        {
            if (instance == null)
            {
                instance = new StudentContainer();
            }
            return instance;
        }

        //metode za dodavanje i prikaz
        public void AddStudent(string name, string lastName, string gpa)
        {
            studentList.Add(new Student()
            { FirstName = name, LastName = lastName, Gpa = gpa, Id = StudentIdGenerator.NextId() });
        }
        
        public List<Student> GetStudents()
        {
            studentList = studentList.OrderBy(x => x.LastName).ToList();  //sort by last name - ascending
            return studentList;
        }
    }
}
