using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project.Code
// StudentIdGenerator class which will provide unique id-s, you may use Singleton pattern 
{
    public class StudentIdGenerator
    {
        private static StudentIdGenerator instance; //singleton pattern
        public int nextId;
        public StudentIdGenerator() { nextId = 1; }
        public static StudentIdGenerator getGenerator()
        {
            if (instance == null)//provjera postoji li instanca generatora
            {
                instance = new StudentIdGenerator(); //ako nema, kreira ju
            }
            return instance;
        }
        public int NextId()
        {
            return nextId++;
        }
    }
}