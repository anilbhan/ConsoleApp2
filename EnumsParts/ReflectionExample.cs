//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Reflection;

//namespace EnumsParts
//{
//   public class ReflectionExample
//    {
//        public static void Main()
//        {
//            Type T = Type.GetType("EnumsParts.customer");
//            PropertyInfo[] pro = T.GetProperties();
//            foreach (PropertyInfo property in pro)
//            {
//                Console.WriteLine(property.GetMethod);
//            }

//            Console.WriteLine("Methods in customers class");

//            MethodInfo[] methods = T.GetMethods();
//            foreach (MethodInfo meth in methods)
//            {
//                Console.WriteLine(meth.ReturnType.Name);
//            }
//        }
//    }
//    public class customer
//    {
//    public int _id { get; set; }
//    public string _Name { get; set; }

//        public customer(int id, string name)
//        {
//            this._id = id;
//            this._Name = name;
//        }

//        public customer()
//        {
//            this._id = -1;
//            this._Name = "ANil";
//        }

//        public void Add()
//        {
//            Console.WriteLine("The ID is={0}",this._id);
//            Console.WriteLine("The ID is={0}", this._Name);

//        }
//    }
//}
