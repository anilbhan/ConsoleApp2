using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsParts
{
    public class ToStringMethod
    {
        public static void Main()
        {
            Student s = new Student();
            s.FirstName = "Hari";
            s.LastName = "Bhandari";
            Console.WriteLine(s);


        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public override string ToString()
        //{
        //    return this.FirstName + ", " + LastName;
        //}

    }
}


