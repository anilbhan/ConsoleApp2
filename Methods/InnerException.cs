using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Methods
{
    public class InnerException
    {
        public static void InnerExceptionHandling()
        {
            try
            {
                Console.WriteLine("Enter the number");
                int FN = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Second number");
                int SN = Convert.ToInt32(Console.ReadLine());

                int sum = FN / SN;


                Console.WriteLine(sum);

            }
            catch (Exception ex)
            {
                string FilePath = @"C:\Users\AnilBhandari\documents\visual studio 2017\Projects\ConsoleApp2\Methods\File\log.txt";

                StreamWriter sw = new StreamWriter(FilePath);
                sw.Write(ex.GetType().Name);
                sw.Close();
            }

        }
    }
}
