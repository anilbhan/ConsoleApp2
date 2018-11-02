using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Methods
{
 public  class ReadFromFolder
    {
        public static void ReadText()
        {
            try
            {
                StreamReader read = new StreamReader(@"C:\Users\AnilBhandari\documents\visual studio 2017\Projects\ConsoleApp2\Methods\File\Cools.txt");
                string readme = read.ReadToEnd();
                Console.WriteLine(readme);
                read.Close();
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("please check if the file {0} exist",ex.FileName);
            }
        }
        //

    }
}
