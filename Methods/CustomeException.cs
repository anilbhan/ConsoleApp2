using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
  public  class CustomeException
    {
        public static void ThrowCustomeExceptionExample()
        {
            try
            {
                throw new UserAlreadySignedUpException();
            }
            catch(UserAlreadySignedUpException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public class UserAlreadySignedUpException :Exception
    {
        
        public UserAlreadySignedUpException(string message) : base()
        {

        }
        public UserAlreadySignedUpException() : base()
        {

        }

        public UserAlreadySignedUpException(string message,Exception InnerException) : base(message, InnerException)
        {

        }
    }
}
