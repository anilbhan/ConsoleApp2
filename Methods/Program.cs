using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            EvenNumbers(500);
            Program p = new Program();
        int sum=    p.returnNumeber(2, 3);
            Console.WriteLine(sum);

            Console.WriteLine("------------------------");
            Console.WriteLine("------------------------");

            int i = 0;
            PassByValue(ref i);
            Console.WriteLine(i);

            Console.WriteLine("------------------------");
            Console.WriteLine("------------------------");
            Console.WriteLine("Returning more than one value from single method");
            int sumtotal;
            int product;
           Calculate(2,5, out sumtotal, out product);
            Console.WriteLine(sumtotal);
            Console.WriteLine(product);
            Console.WriteLine("------------------------");

            int[] numbers = new int[4];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 12;
            numbers[3] = 10;

            ParamsMethod(numbers);

            //explicit conversion example;
            Console.WriteLine("------------------------");

            double a = 100.56456;
            int k = (int)a;
            Console.WriteLine(k);
            Console.WriteLine("------------------------");

            //check for try parse method;
            CheckParse();
            ReadFromFolder.ReadText();

            //Innerexception Examples:
            InnerException.InnerExceptionHandling();
            //Custome Exception Sample

            CustomeException.ThrowCustomeExceptionExample();
            //Handling Exception Abuse

          //  ExceptionHandlingAbuse.HandlingAbuse();
            PreventExceptionAbuse.PreventAbuse();

        }

        public int returnNumeber(int a, int b)
        {
            return a + b;

        }
             
        public static void EvenNumbers(int target)
        {
            int start = 1;
            while (start <= target)
            {
                Console.WriteLine(start);
                start=start+2;
            }


          

    }

        public static void PassByValue(ref int x)
        {
            x = 101;
        }

        public static void Calculate(int FN,int SN,out int sum, out int product)
        {
            sum= FN + SN;
            product = FN * SN;
        }

        public static void ParamsMethod(params int[] Numbers)
        {
            Console.WriteLine("The total length of the arrary is {0}",Numbers.Length);
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }


        //Make use of TryParse and Parse Method;

        public static void CheckParse()
        {
            string str = "100";
            int result = 0;
            bool isconversionsuccessfull=int.TryParse(str, out result);
            if (isconversionsuccessfull)
            {
                Console.WriteLine("successfull");
            }
            else
            {
                Console.WriteLine("Enter Valid input");
            }
        }
}
}
