//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EnumsParts
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //   GetGenderSpecifics.GetGender();
//            EmployeeList.Employee();
//        }

    

        
//    }
    
//    public class EmployeeList
//    {
//        public static void Employee()
//        {

//            Console.WriteLine("THIS ONE IS THE EXAMPLE OF EMPLOYEE GENDER LIST \"WITHOUT\" THE USE OF ENUMS");

//            EmployeeDetails[] employeedetails = new EmployeeDetails[3];
//            employeedetails[0] = new EmployeeDetails
//            {
//                Name = "Ram",
//                Gender = 1
//            };
//            employeedetails[1] = new EmployeeDetails
//            {
//                Name = "Hari",
//                Gender = 0
//            };
//            employeedetails[2] = new EmployeeDetails
//            {
//                Name = "Sita",
//                Gender = 2
//            };

//            foreach (EmployeeDetails emp in employeedetails)
//            {
//                Console.WriteLine("The Name of the Employee is {0} and Gender is {1}",emp.Name,GetGenderList(emp.Gender));
//            }

//            Console.WriteLine("---------------------------------");
//            Console.WriteLine("THIS ONE IS THE EXAMPLE OF EMPLOYEE GENDER LIST WITH  THE USE OF ENUMS");

//            CustomerList.Student();
//        }
//        public static string GetGenderList(int gender)
//        {
//            switch (gender)
//            {
//                case 0:
//                    return "Unknown";
//                case 1:
//                    return "Male";
//                case 2:
//                    return "Female";
//                default:
//                    return "Unknown Data";
                        
//            }
//        }


      
//    }
//    public class EmployeeDetails
//    {
//        public String Name { get; set; }
//        public int Gender { get; set; }
      
//    }





//    // This is the example of ENUMS
//    public enum Gender
//    {
//        Unknown, Male, Female
//    }

//    public class Student
//    {
//        public String Name { get; set; }
//        public Gender Gender { get; set; }

//    }
//    public class CustomerList
//    {
//        public static void Student()
//        {


//            Student[] employeedetails = new Student[3];
//            employeedetails[0] = new Student
//            {
//                Name = "Eric",
//                Gender = Gender.Male
//            };
//            employeedetails[1] = new Student
//            {
//                Name = "Tom",
//                Gender = Gender.Female
//            };
//            employeedetails[2] = new Student
//            {
//                Name = "Sunny",
//                Gender = Gender.Unknown
//            };

//            foreach (Student stdn in employeedetails)
//            {
//                Console.WriteLine("The Name of the Employee is {0} and Gender is {1}", stdn.Name,GetGenderListStudent(stdn.Gender));
//            }


//        }
//        public static string GetGenderListStudent(Gender gender)
//        {
//            switch (gender)
//            {
//                case Gender.Unknown:
//                    return "Unknown";
//                case Gender.Male:
//                    return "Male";
//                case Gender.Female:
//                    return "Female";
//                default:
//                    return "Unknown Data";

//            }
//        }
//    }
        
//}
