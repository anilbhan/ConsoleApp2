using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
 public   class PreventExceptionAbuse
    {
        //Before understanding prevent exception abuse compare code between ExceptionHandlingAbuse.cs and PreventExceptionAbuse.cs

        public static void PreventAbuse()
        {
            try
            {
                int numerator;
                Console.WriteLine("Please enter the Numerator");
                bool IsNumberatorConversionSuccessful = int.TryParse(Console.ReadLine(), out numerator);
                if (IsNumberatorConversionSuccessful)
                {
                    int denomenator;
                    Console.WriteLine("Please enter the Denomenator");
                    bool IsdenomenatorConversionSuccessful = int.TryParse(Console.ReadLine(), out denomenator);
                   
                   
                    if (IsdenomenatorConversionSuccessful & denomenator != 0)
                    {
                        int result = 0;
                        result = numerator / denomenator;
                    }
                    else
                    {
                        if (denomenator == 0)
                        {
                            Console.WriteLine("Denomenator cannot be zero");
                        }
                        else
                        {
                            Console.WriteLine("Denomenator should be valid number {0} & {1}", Int32.MinValue, Int32.MaxValue);

                        }
                    }

                }
                else
                {
                    Console.WriteLine("Numerator should be valid number",Int32.MinValue,Int32.MaxValue);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error",ex);
            }

            // all this exception  checking is exception Abuse. lieu of doing this checking its better to check 
            //whether the user input is incorrect, if that is incorrect program in such way that can be corrected at that time.
        }

    }
}
