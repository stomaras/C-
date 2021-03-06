using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAndExceptionHandling
{
    /*
     * What is an Exception?
     * 
     * In an Application we have 2 # types of error
     * 1) Compile Time Error
     * 2) Runtime Errors -? Abnormal Termination
     *                  - wrong implementation of logic
     *                  - wrong input supplied
     *                  - missing required resources.
     * 
     * Who is responsible for the abnormal termination when runtime errors occurs in the code?
     * 
     * Exception is responsible , it is a class 
     * Representing every different error come into my codes:
     * Some of the classes are pre-defined classes : 1) IndexOutOfBoundsException
     *                           2) DivideByZeroException
     *                           3) OverflowException
     *                           4) FormatException e.t.c
     * 
     * Exception -> Logic For abnormal Termination
     *           -> Contains a readonly Property to display an error message, which is declared as virtual
     *              Property name is "Message"
     * ApplicationException -> Custom Exceptions Generated by the Programmer
     * SystemException -> IndexOutOfBoundsException
     *                 -> FormatException
     *                 -> DivideByZeroException
     *                 -> OverflowException
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     */



    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
