using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Code
{
    public class StudentIdGenerator
    {
            private static StudentIdGenerator instance;
            private int nextID;
            private StudentIdGenerator() { nextID = 1; }
            public static StudentIdGenerator getGenerator()
            {
                if (instance == null)
                {
                    instance = new StudentIdGenerator();
                }
                return instance;
            }
            public int nextId()
            {
                return nextID++;
            }
    }
}